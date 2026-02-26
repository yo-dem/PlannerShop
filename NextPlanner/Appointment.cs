namespace NextPlanner
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public Color Color { get; set; } = Color.SteelBlue;
        public string ClientName { get; set; } = "";
        public string OperatorName { get; set; } = "";
        public int ServiceId { get; set; }
        public string ServiceName { get; set; } = "";
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public AppointmentStatus Status { get; set; }
        public string Notes { get; set; } = "";
        public DateTime Timestamp { get; set; }

        public Appointment()
        {
            Timestamp = DateTime.Now;
            Status = AppointmentStatus.Prenotato;
        }

        // Fix: era (Start - End) che dava valore negativo
        public int DurataMinuti => (int)(End - Start).TotalMinutes;
    }

    public enum AppointmentStatus
    {
        Prenotato,
        Confermato,
        Completato,
        Annullato,
        Assente
    }
}