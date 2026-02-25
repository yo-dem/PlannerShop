using PlannerShop.Data;
using System.Data;

namespace PlannerShop.Forms.Agenda.Forms.Cruds
{
    /// <summary>
    /// Autocomplete non-obbligatorio per il campo Cliente.
    /// Mostra un ListBox overlay mentre si digita; la selezione
    /// è opzionale — si può sempre scrivere un nome libero.
    /// 
    /// Uso:
    ///   _autocomplete = new ClienteAutocomplete(txtCliente, this);
    ///   // nel Dispose della form:
    ///   _autocomplete.Dispose();
    /// </summary>
    internal sealed class ClienteAutocomplete : IDisposable
    {
        private readonly TextBox _txt;
        private readonly Form _owner;
        private readonly ListBox _list;
        private bool _selecting = false;   // evita loop TextChanged ↔ selezione

        public ClienteAutocomplete(TextBox txt, Form owner)
        {
            _txt = txt;
            _owner = owner;

            // ListBox flottante aggiunto direttamente alla Form
            // così si sovrappone a tutti gli altri controlli
            _list = new ListBox
            {
                Visible = false,
                BorderStyle = BorderStyle.FixedSingle,
                Font = txt.Font,
                IntegralHeight = false,
                ItemHeight = 20,
            };

            _owner.Controls.Add(_list);
            _list.BringToFront();

            _txt.TextChanged += OnTextChanged;
            _txt.KeyDown += OnKeyDown;
            _txt.Leave += OnLeave;
            _list.Click += OnListClick;
            _list.KeyDown += OnListKeyDown;
            _owner.Move += OnOwnerMove;
            _owner.Resize += OnOwnerMove;
        }

        // ── Event handlers ──────────────────────────────────────────

        private void OnTextChanged(object? sender, EventArgs e)
        {
            if (_selecting) return;

            string term = _txt.Text.Trim();
            if (term.Length < 1) { Hide(); return; }

            var dt = ModelClienti.searchClienti(term);
            if (dt.Rows.Count == 0) { Hide(); return; }

            _list.BeginUpdate();
            _list.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string nome = row["NOME"]?.ToString()?.Trim() ?? "";
                string cognome = row["COGNOME"]?.ToString()?.Trim() ?? "";
                // Formato: "COGNOME NOME" in maiuscolo, come fa già BuildAppointment
                string full = $"{cognome} {nome}".Trim().ToUpper();
                if (!string.IsNullOrEmpty(full) && !_list.Items.Contains(full))
                    _list.Items.Add(full);
            }
            _list.EndUpdate();

            if (_list.Items.Count == 0) { Hide(); return; }

            // Posiziona il listbox sotto il TextBox
            int maxItems = Math.Min(_list.Items.Count, 7);
            _list.Height = maxItems * _list.ItemHeight + 2;
            var pt = _owner.PointToClient(_txt.Parent!.PointToScreen(
                                new Point(_txt.Left, _txt.Bottom)));
            _list.Location = pt;
            _list.Width = _txt.Width;
            _list.Visible = true;
            _list.BringToFront();
        }

        private void OnKeyDown(object? sender, KeyEventArgs e)
        {
            if (!_list.Visible) return;

            if (e.KeyCode == Keys.Down)
            {
                _list.Focus();
                _list.SelectedIndex = 0;
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Hide();
                e.Handled = true;
            }
        }

        private void OnListKeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                Commit();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Hide();
                _txt.Focus();
                e.Handled = true;
            }
        }

        private void OnListClick(object? sender, EventArgs e) => Commit();

        private void OnLeave(object? sender, EventArgs e)
        {
            // Piccolo delay sul thread UI: se il focus è andato al ListBox non nascondere
            var t = new System.Windows.Forms.Timer { Interval = 150 };
            t.Tick += (_, _) =>
            {
                t.Stop();
                t.Dispose();
                if (!_list.IsDisposed && !_list.Focused)
                    Hide();
            };
            t.Start();
        }

        private void OnOwnerMove(object? sender, EventArgs e) => Hide();

        // ── Helpers ─────────────────────────────────────────────────

        private void Commit()
        {
            if (_list.SelectedItem is string s)
            {
                _selecting = true;
                _txt.Text = s;
                _txt.SelectionStart = s.Length;
                _selecting = false;
            }
            Hide();
            _txt.Focus();
        }

        private void Hide() => _list.Visible = false;

        public void Dispose()
        {
            _txt.TextChanged -= OnTextChanged;
            _txt.KeyDown -= OnKeyDown;
            _txt.Leave -= OnLeave;
            _list.Click -= OnListClick;
            _list.KeyDown -= OnListKeyDown;
            _owner.Move -= OnOwnerMove;
            _owner.Resize -= OnOwnerMove;
            _list.Dispose();
        }
    }
}