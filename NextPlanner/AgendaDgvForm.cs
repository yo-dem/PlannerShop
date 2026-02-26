using PlannerShop.Data;
using PlannerShop.Forms.Agenda.Forms.Cruds;
using System.Globalization;

namespace NextPlanner
{
    public partial class AgendaDgvForm : Form
    {
        private readonly CultureInfo _it = new("it-IT");
        private DateTime _weekStart;
        private readonly AgendaCanvasPanel _canvas;

        public AgendaDgvForm()
        {
            InitializeComponent();
            _weekStart = GetStartOfWeek(DateTime.Today);

            // Crea il canvas e aggancialo sotto la toolbar (Dock.Fill rispetta i Dock.Top già presenti)
            _canvas = new AgendaCanvasPanel
            {
                Dock = DockStyle.Fill
            };
            _canvas.RequestNewAppointment += OnNewAppointment;
            _canvas.RequestEditAppointment += OnEditAppointment;

            Controls.Add(_canvas);
            _canvas.BringToFront();
            UpdateWeekUI();
        }


        // ================================================================
        // NAVIGAZIONE
        // ================================================================
        private void btnPrevWeek_Click(object sender, EventArgs e)
        {
            _weekStart = _weekStart.AddDays(-7);
            UpdateWeekUI();
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            _weekStart = _weekStart.AddDays(7);
            UpdateWeekUI();
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            _weekStart = GetStartOfWeek(DateTime.Today);
            UpdateWeekUI();
            _canvas.ScrollToCurrentTime();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            btnWeek.Text = "OGGI  " + DateTime.Now.ToString("HH:mm:ss");
        }


        // ================================================================
        // AGGIORNAMENTO UI
        // ================================================================
        private void UpdateWeekUI()
        {
            UpdateWeekLabel();
            _canvas.SetWeek(_weekStart);
            LoadAndRefresh();
        }

        private void UpdateWeekLabel()
        {
            DateTime end = _weekStart.AddDays(6);
            string text = _weekStart.Month == end.Month
                ? $"{_weekStart.Day} – {end.Day} {_weekStart:MMMM yyyy}"
                : $"{_weekStart:dd MMM} – {end:dd MMM yyyy}";
            lblTimeSlot.Text = _it.TextInfo.ToTitleCase(text);
        }

        private void LoadAndRefresh()
        {
            try
            {
                var dt = ModelAppuntamenti.GetAppuntamentiBySettimana(_weekStart);
                var apps = new List<Appointment>();
                foreach (System.Data.DataRow row in dt.Rows)
                    apps.Add(ModelAppuntamenti.RowToAppointment(row));
                _canvas.LoadAppointments(apps);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[Agenda] {ex.Message}");
            }
        }


        // ================================================================
        // GESTIONE APPUNTAMENTI
        // ================================================================
        private void OnNewAppointment(DateTime day, TimeSpan time)
        {
            var form = new AppointmentInsertForm(day, time);
            if (form.ShowDialog() == DialogResult.OK)
                LoadAndRefresh();
        }

        private void OnEditAppointment(Appointment app)
        {
            var form = new AppointmentEditForm(app);
            if (form.ShowDialog() == DialogResult.OK)
                LoadAndRefresh();
        }


        // ================================================================
        // HELPER
        // ================================================================
        private static DateTime GetStartOfWeek(DateTime date)
        {
            int diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
            return date.AddDays(-diff).Date;
        }
    }
}