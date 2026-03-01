using PlannerShop.Data;

namespace PlannerShop.Forms.Agenda.Forms.Cruds
{
    public partial class AppointmentEditForm : Form
    {
        public Appointment? Result { get; private set; }
        public bool IsDeleted { get; private set; } = false;

        private readonly int _appointmentId;
        private bool _titleManuallyEdited = false;
        private bool _loadingComplete = false;

        public AppointmentEditForm(Appointment app)
        {
            InitializeComponent();
            _appointmentId = app.Id;
            InitializeDefaults();
            HookEvents();
            LoadAppointment(app);
        }

        private void InitializeDefaults()
        {
            cmbStato.DataSource = Enum.GetValues(typeof(AppointmentStatus));
            cmbStato.SelectedItem = AppointmentStatus.Prenotato;
            AppointmentInsertForm.HighlightColorButtons(
                AppointmentInsertForm.Palette[0], btnColor1, btnColor2, btnColor3, btnColor4);
        }

        private void HookEvents()
        {
            txtCliente.TextChanged += (s, e) => AutoGenerateTitle();
            txtServizio.TextChanged += (s, e) => AutoGenerateTitle();
            txtTitolo.TextChanged += (s, e) => { if (_loadingComplete) _titleManuallyEdited = true; };
            dtpOraInizio.ValueChanged += (s, e) => UpdateOraFine();
            btnColor1.Click += (s, e) => SelectColor(AppointmentInsertForm.Palette[0]);
            btnColor2.Click += (s, e) => SelectColor(AppointmentInsertForm.Palette[1]);
            btnColor3.Click += (s, e) => SelectColor(AppointmentInsertForm.Palette[2]);
            btnColor4.Click += (s, e) => SelectColor(AppointmentInsertForm.Palette[3]);
        }

        private void SelectColor(Color c)
        {
            pnlColore.BackColor = c;
            AppointmentInsertForm.HighlightColorButtons(c, btnColor1, btnColor2, btnColor3, btnColor4);
        }

        private void LoadAppointment(Appointment app)
        {
            txtTitolo.Text = app.Title;
            txtCliente.Text = app.ClientName;
            txtOperatore.Text = app.OperatorName;
            txtServizio.Text = app.ServiceName;
            dtpData.Value = app.Start.Date;
            dtpOraInizio.Value = DateTime.Today.Add(app.Start.TimeOfDay);
            dtpOraFine.Value = DateTime.Today.Add(app.End.TimeOfDay);
            cmbStato.SelectedItem = app.Status;
            txtNote.Text = app.Notes;

            // Cerca il colore nella palette; se non trovato usa il primo
            var match = AppointmentInsertForm.Palette
                .FirstOrDefault(c => c.ToArgb() == app.Color.ToArgb());
            SelectColor(match == default ? AppointmentInsertForm.Palette[0] : match);
            _titleManuallyEdited = false;
            _loadingComplete = true;
        }

        private void AutoGenerateTitle()
        {
            if (!_loadingComplete) return;
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

        private void UpdateOraFine()
        {
            if (dtpOraFine.Value <= dtpOraInizio.Value)
                dtpOraFine.Value = dtpOraInizio.Value.AddMinutes(30);
        }

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
                Id = _appointmentId,
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
            ModelAppuntamenti.EditAppuntamento(_appointmentId, Result);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Eliminare \"{txtTitolo.Text}\"?", "Conferma",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            ModelAppuntamenti.DeleteAppuntamento(_appointmentId);
            IsDeleted = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close(); }
        private void txtNote_Enter(object sender, EventArgs e) => AcceptButton = null;
        private void txtNote_Leave(object sender, EventArgs e) => AcceptButton = btnOk;
        private void txtCliente_TextChanged(object sender, EventArgs e) => lblCliente.ForeColor = Color.Black;
        private void txtTitolo_TextChanged2(object sender, EventArgs e) => lblTitolo.ForeColor = Color.Black;
        private void dtpOraFine_ValueChanged(object sender, EventArgs e) => lblOraFine.ForeColor = Color.Black;
    }
}