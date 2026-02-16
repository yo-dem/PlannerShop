
namespace PlannerShop.Forms.Agenda
{
    internal class Appointment
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public Color Color { get; set; } = Color.SteelBlue;

        // Cliente
        public string ClientName { get; set; }

        // Operatore
        public string OperatorName { get; set; }

        // Trattamento
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }

        // Orari
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        // Stato appuntamento
        public AppointmentStatus Status { get; set; }

        // Note opzionali
        public string Notes { get; set; }

        // Audit
        public DateTime Timestamp{ get; set; }

        public Appointment()
        {
            Timestamp = DateTime.Now;
            Status = AppointmentStatus.Prenotato;
        }

        // Durata in minuti (calcolata)
        public int DurataMinuti
        {
            get
            {
                return (int)(Start - End).TotalMinutes;
            }
        }

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
