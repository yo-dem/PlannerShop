# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

PlannerShop is a Windows desktop application (C# / Windows Forms / .NET 8.0) for business management: clients, products, services, suppliers, purchases, and appointment scheduling.

## Commands

```bash
dotnet build                    # Build the project
dotnet run --project PlannerShop  # Run the application
dotnet publish -c Release       # Build release executable
```

No test suite is configured.

## Architecture

**Pattern**: Monolithic Windows Forms app with a simple layered structure.

### Data Access

- `PlannerShop/Data/DBUtility.cs` — a `struct` with static helpers that wrap all SQLite queries. Every form calls this directly; there is no repository or service layer.
- `PlannerShop/Data/Model*.cs` — plain data-holder classes (e.g., `ModelClienti`, `ModelProdotti`) returned from `DBUtility` queries.

### Two SQLite Databases

| File | Purpose |
|------|---------|
| `PlannerShop/Data/PSDB.db` | Main data: TCLIENTI, TPRODOTTI, TSERVIZI, TFORNITORI, TACQUISTI, TOPZIONI, password |
| `PlannerShop/Forms/Agenda/Data/PSDB_Agenda.db` | Appointment scheduling |

Both `.db` files are copied to the output directory on build (configured in `PlannerShop.csproj`).

### UI Structure

```
Program.cs
  └─ LoginForm (if password protection is enabled)
       └─ MainForm (hub: shows client list, opens all other forms)
            ├─ Forms/Cruds/          CRUD dialogs for clients, products, services, suppliers
            ├─ Forms/Cruds/Purchases/ Purchase forms
            ├─ Forms/Agenda/         Visual calendar/appointment scheduling
            └─ Forms/Utility/        Settings, email, birthday notifications, statistics
```

`MainForm` acts as the application shell and passes data between child forms via constructor parameters or public properties.

### Agenda Module

`Forms/Agenda/` is a self-contained scheduling subsystem with its own database and a custom-drawn canvas (`AgendaCanvasPanel.cs`). Appointments are represented by the `Appointment` class and rendered directly via GDI+.
