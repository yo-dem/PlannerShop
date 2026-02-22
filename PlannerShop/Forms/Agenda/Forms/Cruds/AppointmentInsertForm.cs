using System.Globalization;

namespace PlannerShop.Forms.Agenda.Forms.Cruds
{
    /// <summary>
    /// Form per l'inserimento di un nuovo appuntamento.
    /// Predisposta per il salvataggio su SQLite (non ancora implementato).
    /// </summary>
    public partial class AppointmentInsertForm : Form
    {
        // ============================================================
        // STATO
        // ============================================================

        /// <summary>
        /// Appuntamento costruito dalla form. Null se annullato.
        /// </summary>
        public Appointment? Result { get; private set; }

        private bool _titleManuallyEdited = false;

        // ============================================================
        // COSTRUTTORE
        // ============================================================

        public AppointmentInsertForm()
        {
            InitializeComponent();
            InitializeDefaults();
            HookEvents();
        }

        /// <summary>
        /// Costruttore con data/ora preselezionate (passate dalla cella cliccata).
        /// </summary>
        public AppointmentInsertForm(DateTime startDate, TimeSpan startTime) : this()
        {
            dtpData.Value = startDate.Date;
            dtpOraInizio.Value = DateTime.Today.Add(startTime);
            UpdateOraFine();
        }

        // ============================================================
        // INIZIALIZZAZIONE
        // ============================================================

        private void InitializeDefaults()
        {
            // Stato default
            cmbStato.DataSource = Enum.GetValues(typeof(AppointmentStatus));
            cmbStato.SelectedItem = AppointmentStatus.Prenotato;

            // Colore default
            pnlColore.BackColor = Color.MediumSlateBlue;

            // Data/ora default
            dtpData.Value = DateTime.Today;
            dtpOraInizio.Value = DateTime.Today.AddHours(9);
            dtpOraFine.Value = DateTime.Today.AddHours(9).AddMinutes(30);
        }

        private void HookEvents()
        {
            // Auto-genera titolo da cliente + servizio
            txtCliente.TextChanged += (s, e) => AutoGenerateTitle();
            dtpOraInizio.ValueChanged += (s, e) => UpdateOraFine();
            txtServizio.TextChanged += (s, e) => AutoGenerateTitle();
            txtTitolo.TextChanged += (s, e) => { _titleManuallyEdited = true; };

            // Ora fine si aggiorna all'ora inizio
            dtpOraInizio.ValueChanged += (s, e) => UpdateOraFine();
        }

        // ============================================================
        // LOGICA
        // ============================================================

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

            // Reset flag: il cambio sopra è automatico, non manuale
            _titleManuallyEdited = false;
        }

        private void UpdateOraFine()
        {
            // Propone +30 minuti di default
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

        /// <summary>
        /// Costruisce l'oggetto Appointment dai valori della form.
        /// TODO: sostituire con salvataggio su SQLite.
        /// </summary>
        private Appointment BuildAppointment()
        {
            var startDate = dtpData.Value.Date;

            var start = startDate
                .Add(dtpOraInizio.Value.TimeOfDay);

            var end = startDate
                .Add(dtpOraFine.Value.TimeOfDay);

            return new Appointment
            {
                Title = txtTitolo.Text.Trim(),
                ClientName = txtCliente.Text.Trim().ToUpper(),
                OperatorName = txtOperatore.Text.Trim().ToUpper(),
                ServiceName = txtServizio.Text.Trim().ToUpper(),
                Start = start,
                End = end,
                Status = (AppointmentStatus)cmbStato.SelectedItem!,
                Color = pnlColore.BackColor,
                Notes = txtNote.Text.Trim()
            };
        }

        // ============================================================
        // EVENTI UI
        // ============================================================

        private void btnColore_Click(object sender, EventArgs e)
        {
            using var dlg = new ColorDialog
            {
                Color = pnlColore.BackColor,
                FullOpen = true,
                AnyColor = true,
                AllowFullOpen = true
            };

            if (dlg.ShowDialog() == DialogResult.OK)
                pnlColore.BackColor = dlg.Color;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!InputCheck()) return;

            Result = BuildAppointment();

            // TODO: ModelAppointments.Insert(Result);

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

        // ============================================================
        // RESET COLORI LABEL (validazione)
        // ============================================================

        private void txtCliente_TextChanged(object sender, EventArgs e) => lblCliente.ForeColor = Color.Black;
        private void txtTitolo_TextChanged2(object sender, EventArgs e) => lblTitolo.ForeColor = Color.Black;
        private void dtpOraFine_ValueChanged(object sender, EventArgs e) => lblOraFine.ForeColor = Color.Black;
    }
}