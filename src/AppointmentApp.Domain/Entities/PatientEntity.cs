using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppointmentApp.Domain.Entities
{
    public class PatientEntity
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PatientDescription { get; set; }

        public ICollection<AppointmentEntity> Appointment { get; set; }
    }
}
