using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppointmentApp.Domain.Entities
{
    public class AppointmentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentTitle { get; set; }
        public string AppointmentDescription { get; set; }
        public string AppointmentType { get; set; }
        public bool Attended { get; set; }
        public int UserId { get; set; }
        public int PatientId { get; set; }

        [ForeignKey("UserId")]
        public virtual UserEntity User { get; set; }
        [ForeignKey("PatientId")]
        public virtual PatientEntity Patient { get; set; }

    }
}
