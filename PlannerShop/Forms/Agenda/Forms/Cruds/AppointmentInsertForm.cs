using PlannerShop.Data;

namespace PlannerShop.Forms.Agenda.Forms.Cruds
{
    public partial class AppointmentInsertForm : Form
    {
        public Appointment? Result { get; private set; }
        private bool _titleManuallyEdited = false;
        private ClienteAutocomplete? _autocomplete;

        // Palette fissa condivisa con EditForm
        internal static readonly Color[] Palette =
        [
            Color.FromArgb(0x7B, 0x68, 0xEE),   // viola       #7B68EE
            Color.FromArgb(0x1A, 0x23, 0x7E),   // blu navy    #1A237E
            Color.FromArgb(0xFF, 0x8C, 0x00),   // arancio     #FF8C00
            Color.FromArgb(0x2E, 0x8B, 0x57),   // verde       #2E8B57
            Color.FromArgb(0xB2, 0x22, 0x22),   // rosso       #B22222
            Color.FromArgb(0xB8, 0x86, 0x0B),   // oro scuro   #B8860B
        ];

        public AppointmentInsertForm()
        {
            InitializeComponent();
            InitializeDefaults();
            HookEvents();
        }

        public AppointmentInsertForm(DateTime startDate, TimeSpan startTime) : this()
        {
            dtpData.Value = startDate.Date;
            dtpOraInizio.Value = DateTime.Today.Add(startTime);
            dtpOraFine.Value = DateTime.Today.Add(startTime).AddMinutes(30);
        }

        private void InitializeDefaults()
        {
            cmbStato.DataSource = Enum.GetValues(typeof(AppointmentStatus));
            cmbStato.SelectedItem = AppointmentStatus.Prenotato;
            dtpData.Value = DateTime.Today;
            dtpOraInizio.Value = DateTime.Today.AddHours(9);
            dtpOraFine.Value = DateTime.Today.AddHours(9).AddMinutes(30);
            SelectColor(Palette[0]);
        }

        private void HookEvents()
        {
            txtCliente.TextChanged += (s, e) => AutoGenerateTitle();
            txtServizio.TextChanged += (s, e) => AutoGenerateTitle();
            txtTitolo.TextChanged += (s, e) => { _titleManuallyEdited = true; };
            dtpOraInizio.ValueChanged += (s, e) => UpdateOraFine();
            btnColor1.Click += (s, e) => SelectColor(Palette[0]);
            btnColor2.Click += (s, e) => SelectColor(Palette[1]);
            btnColor3.Click += (s, e) => SelectColor(Palette[2]);
            btnColor4.Click += (s, e) => SelectColor(Palette[3]);
            btnColor5.Click += (s, e) => SelectColor(Palette[4]);
            btnColor6.Click += (s, e) => SelectColor(Palette[5]);
            _autocomplete = new ClienteAutocomplete(txtCliente, this);
        }

        internal void SelectColor(Color c)
        {
            pnlColore.BackColor = c;
            HighlightColorButtons(c, btnColor1, btnColor2, btnColor3, btnColor4, btnColor5, btnColor6);
        }

        internal static void HighlightColorButtons(Color selected, params Button[] buttons)
        {
            foreach (var btn in buttons)
            {
                bool active = btn.BackColor.ToArgb() == selected.ToArgb();
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = active ? 3 : 1;
                btn.FlatAppearance.BorderColor = active ? Color.White : Color.FromArgb(80, 80, 80);
            }
        }

        private void AutoGenerateTitle()
        {
            if (_titleManuallyEdited) return;
            string cliente = txtCliente.Text.Trim();
            string servizio = txtServizio.Text.Trim();
            if (!string.IsNullOrEmpty(cliente) && !string.IsNullOrEmpty(servizio))
                txtTitolo.Text = $"{servizio} – {cliente}";
            else if (!string.IsNullOrEmpty(cliente))
                txtTitolo.Text = $"Appuntamento {cliente}";
            else
                txtTitolo.Text = string.Empty;
            _titleManuallyEdited = false;
        }

        private void UpdateOraFine() =>
            dtpOraFine.Value = dtpOraInizio.Value.AddMinutes(30);

        private bool InputCheck()
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(txtCliente.Text)) { lblCliente.ForeColor = Color.Red; ok = false; }
            if (string.IsNullOrWhiteSpace(txtTitolo.Text)) { lblTitolo.ForeColor = Color.Red; ok = false; }
            if (dtpOraFine.Value <= dtpOraInizio.Value)
            {
                lblOraFine.ForeColor = Color.Red;
                MessageBox.Show("L'ora di fine deve essere successiva all'ora di inizio.",
                    "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ok = false;
            }
            return ok;
        }

        private Appointment BuildAppointment()
        {
            var d = dtpData.Value.Date;
            return new Appointment
            {
                Title = txtTitolo.Text.Trim(),
                ClientName = txtCliente.Text.Trim().ToUpper(),
                OperatorName = txtOperatore.Text.Trim().ToUpper(),
                ServiceName = txtServizio.Text.Trim().ToUpper(),
                Start = d.Add(dtpOraInizio.Value.TimeOfDay),
                End = d.Add(dtpOraFine.Value.TimeOfDay),
                Status = (AppointmentStatus)cmbStato.SelectedItem!,
                Color = pnlColore.BackColor,
                Notes = txtNote.Text.Trim()
            };
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!InputCheck()) return;
            Result = BuildAppointment();
            ModelAppuntamenti.AddAppuntamento(Result);
            DialogResult = DialogResult.OK;
            Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) _autocomplete?.Dispose();
            base.Dispose(disposing);
        }

        private void btnAnnulla_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close(); }
        private void txtNote_Enter(object sender, EventArgs e) => AcceptButton = null;
        private void txtNote_Leave(object sender, EventArgs e) => AcceptButton = btnOk;
        private void txtCliente_TextChanged(object sender, EventArgs e) => lblCliente.ForeColor = Color.Black;
        private void txtTitolo_TextChanged2(object sender, EventArgs e) => lblTitolo.ForeColor = Color.Black;
        private void dtpOraFine_ValueChanged(object sender, EventArgs e) => lblOraFine.ForeColor = Color.Black;
    }
}