using PlannerShop.Data;

namespace PlannerShop.Forms.Agenda.Forms.Cruds
{
    /// <summary>
    /// Form per la visualizzazione e modifica di un appuntamento esistente.
    /// Struttura identica ad AppointmentInsertForm.
    /// </summary>
    public partial class AppointmentEditForm : Form
    {
        // ============================================================
        // STATO
        // ============================================================

        public Appointment? Result { get; private set; }
        public bool IsDeleted { get; private set; } = false;

        private readonly int _appointmentId;
        private bool _titleManuallyEdited = false;

        // ============================================================
        // COSTRUTTORE
        // ============================================================

        public AppointmentEditForm(Appointment app)
        {
            InitializeComponent();
            _appointmentId = app.Id;
            InitializeDefaults();
            HookEvents();
            LoadAppointment(app);
        }

        // ============================================================
        // INIZIALIZZAZIONE
        // ============================================================

        private void InitializeDefaults()
        {
            cmbStato.DataSource   = Enum.GetValues(typeof(AppointmentStatus));
            cmbStato.SelectedItem = AppointmentStatus.Prenotato;
            pnlColore.BackColor   = Color.MediumSlateBlue;
        }

        private void HookEvents()
        {
            txtCliente.TextChanged    += (s, e) => AutoGenerateTitle();
            txtServizio.TextChanged   += (s, e) => AutoGenerateTitle();
            txtTitolo.TextChanged     += (s, e) => { _titleManuallyEdited = true; };
            dtpOraInizio.ValueChanged += (s, e) => UpdateOraFine();
        }

        /// <summary>
        /// Popola tutti i campi della form con i dati dell'appuntamento.
        /// </summary>
        private void LoadAppointment(Appointment app)
        {
            // Sospendi auto-generazione titolo durante il caricamento
            _titleManuallyEdited = true;

            txtTitolo.Text    = app.Title;
            txtCliente.Text   = app.ClientName;
            txtOperatore.Text = app.OperatorName;
            txtServizio.Text  = app.ServiceName;
            dtpData.Value     = app.Start.Date;
            dtpOraInizio.Value = DateTime.Today.Add(app.Start.TimeOfDay);
            dtpOraFine.Value   = DateTime.Today.Add(app.End.TimeOfDay);
            cmbStato.SelectedItem = app.Status;
            pnlColore.BackColor   = app.Color;
            txtNote.Text = app.Notes;
        }

        // ============================================================
        // LOGICA
        // ============================================================

        private void AutoGenerateTitle()
        {
            if (_titleManuallyEdited) return;

            string cliente  = txtCliente.Text.Trim();
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

            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                lblCliente.ForeColor = Color.Red;
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtTitolo.Text))
            {
                lblTitolo.ForeColor = Color.Red;
                ok = false;
            }

            if (dtpOraFine.Value <= dtpOraInizio.Value)
            {
                lblOraFine.ForeColor = Color.Red;
                MessageBox.Show(
                    "L'ora di fine deve essere successiva all'ora di inizio.",
                    "Attenzione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                ok = false;
            }

            return ok;
        }

        private Appointment BuildAppointment()
        {
            var startDate = dtpData.Value.Date;

            return new Appointment
            {
                Id           = _appointmentId,
                Title        = txtTitolo.Text.Trim(),
                ClientName   = txtCliente.Text.Trim().ToUpper(),
                OperatorName = txtOperatore.Text.Trim().ToUpper(),
                ServiceName  = txtServizio.Text.Trim().ToUpper(),
                Start        = startDate.Add(dtpOraInizio.Value.TimeOfDay),
                End          = startDate.Add(dtpOraFine.Value.TimeOfDay),
                Status       = (AppointmentStatus)cmbStato.SelectedItem!,
                Color        = pnlColore.BackColor,
                Notes        = txtNote.Text.Trim()
            };
        }

        // ============================================================
        // EVENTI UI
        // ============================================================

        private void btnColore_Click(object sender, EventArgs e)
        {
            using var dlg = new ColorDialog
            {
                Color        = pnlColore.BackColor,
                FullOpen     = true,
                AnyColor     = true,
                AllowFullOpen = true
            };

            if (dlg.ShowDialog() == DialogResult.OK)
                pnlColore.BackColor = dlg.Color;
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
            var confirm = MessageBox.Show(
                $"Eliminare l'appuntamento \"{txtTitolo.Text}\"?",
                "Conferma eliminazione",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            ModelAppuntamenti.DeleteAppuntamento(_appointmentId);
            IsDeleted    = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtNote_Enter(object sender, EventArgs e) => AcceptButton = null;
        private void txtNote_Leave(object sender, EventArgs e) => AcceptButton = btnOk;

        // Reset colori validazione
        private void txtCliente_TextChanged(object sender, EventArgs e) => lblCliente.ForeColor = Color.Black;
        private void txtTitolo_TextChanged2(object sender, EventArgs e) => lblTitolo.ForeColor  = Color.Black;
        private void dtpOraFine_ValueChanged(object sender, EventArgs e) => lblOraFine.ForeColor = Color.Black;
    }
}
