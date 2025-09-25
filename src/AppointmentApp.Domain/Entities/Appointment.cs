namespace AppointmentApp.Domain.Entities
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentTitle { get; set; }
        public string AppointmentDescription { get; set; }
        public string AppointmentType { get; set; }
        public bool Attended { get; set; }
        public User Doctor { get; set; }
        public Patient Patient { get; set; }
        
    }
}
