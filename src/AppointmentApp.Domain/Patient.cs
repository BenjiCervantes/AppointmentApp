namespace AppointmentApp.Domain.Entities
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PatientDescription { get; set; }
    }
}
