# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

PlannerShop is a Windows desktop application (C# / Windows Forms / .NET 8.0) for business management: clients, products, services, suppliers, purchases, and appointment scheduling. The UI is in Italian.

## Commands

```bash
dotnet build                      # Build the project
dotnet run --project PlannerShop  # Run the application
dotnet publish -c Release         # Build release executable
```

No test suite is configured.

## Architecture

**Pattern**: Monolithic Windows Forms app with a direct-call data access layer — no repository or service layer.

### Data Access

- `PlannerShop/Data/DBUtility.cs` — a `struct` with two static methods: `GetDBData()` (SELECT → DataTable) and `SetDBData()` (INSERT/UPDATE/DELETE). All forms call this directly with parameterized queries.
- `PlannerShop/Data/Model*.cs` — static structs that own all SQL for one entity (e.g., `ModelClienti`, `ModelProdotti`). They call `DBUtility` internally and return plain data objects.
- `PlannerShop/Forms/Agenda/Data/DBUtilityAgenda.cs` — identical pattern but targets the second database.

### Two SQLite Databases

| File | Purpose |
|------|---------|
| `PlannerShop/Data/PSDB.db` | Main data: TCLIENTI, TPRODOTTI, TSERVIZI, TFORNITORI, TACQUISTI, TOpzioni, TPWD |
| `PlannerShop/Forms/Agenda/Data/PSDB_Agenda.db` | Appointment scheduling |

Both `.db` files are copied to the output directory on build (configured in `PlannerShop.csproj`).

### UI Structure

```
Program.cs
  └─ LoginForm (if password protection is enabled)
       └─ MainForm (hub: shows entity list, opens all child forms)
            ├─ Forms/Cruds/           CRUD dialogs for clients, products, services, suppliers
            ├─ Forms/Cruds/Purchases/ Purchase transaction forms
            ├─ Forms/Agenda/          Visual calendar/appointment scheduling
            └─ Forms/Utility/         Settings, email, birthday notifications, statistics
```

`MainForm` acts as the application shell. Child forms are always modal (`ShowDialog`). Communication between parent and child uses public boolean flags on the child form (`isDone`, `isDelete`, `logged`) that the parent reads after the dialog closes.

### CRUD Form Pattern

All insert/edit forms follow the same structure:
1. **Insert**: Constructor initializes UI; `btnOk_Click` validates (`InputCheck()`), calls `Model.add*()`, sets `isDone = true`.
2. **Edit**: Constructor takes an ID; `LoadForm()` populates fields; `btnOk_Click` calls `Model.edit*()`; `btnDelete_Click` shows `DeleteForm` confirmation then calls `Model.delete*()` and sets `isDelete = true`.
3. **Validation**: Required-field labels turn red on failure. Email validated with regex only when non-empty (email is optional everywhere). Multi-line TextBox fields temporarily set `AcceptButton = null` so Enter doesn't submit.
4. **After close**: `MainForm` checks `isDone`/`isDelete`, reloads the grid, then re-selects the row by ID to preserve scroll position.

### Key Domain Rules

- **Prices** (products/services): Three fields — `PREZZO_NETTO` (pre-tax), `PREZZO_IVATO` (auto-calculated: Netto × (1 + ALIQUOTA%)), `PREZZO_VENDITA` (actual selling price, set independently).
- **Birthdays**: Stored as `DD-MM` string; queried with `SUBSTR(COMPLEANNO, 4, 2) = STRFTIME('%m', 'now')` (month only). MainForm shows a red gift icon if any client has a birthday this month.
- **Purchases / transactions**: Items in one session share a single TIMESTAMP datetime. There is no explicit transaction ID — `TACQUISTI` rows are grouped by `(IDCLIENTE, TIMESTAMP)`. Deletions are soft (`ISDELETED = 'TRUE'`).
- **Inventory alerts**: MainForm colors product rows red when `QNT = 0` and orange when `0 < QNT ≤ 10`.
- **IBAN validation** (suppliers): Regex format check + Mod-97 checksum.

### Agenda Module

`Forms/Agenda/` is self-contained with its own database. Key files:

- `AgendaCanvasPanel.cs` — double-buffered custom control rendered entirely via GDI+. Layout: 7-day week view, 56 time slots/day (08:00–22:00 in 15-min intervals). Supports drag-to-move and drag-to-resize appointments via mouse events.
- `Appointment.cs` — data model with `AppointmentStatus` enum (Prenotato, Confermato, Completato, Annullato, Assente). Terminal statuses (`IsTerminal` property) lock all fields except the status dropdown in `AppointmentEditForm`.
- `NOMECLIENTE` and `OPERATORE` in `TAppuntamenti` are free-text strings, not foreign keys to `TCLIENTI`.

### Utility Layer

- `Forms/DgvUtils.cs` — static helper that applies consistent styling to every `DataGridView` (font, padding, colors, selection appearance).
- `Forms/Utility/DeleteForm.cs` — reusable confirmation dialog; caller reads `result` boolean after `ShowDialog`.
- `Forms/Utility/SettingsForm.cs` — manages password protection, email SMTP config (stored in `TOpzioni`), and DB backup to `Data/Archivio/PSDB_[timestamp].db`.
- `Forms/Utility/StatsForm.cs` — tabbed statistics view with time filters and toggle between bar/pie charts (`System.Windows.Forms.DataVisualization.Charting`).
