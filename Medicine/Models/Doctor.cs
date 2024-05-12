using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Models
{
	public class Doctor
	{
        [Required(ErrorMessage = "The Doctor Id is Required")]
        public int Id { get; set; }
		public string? Bio { get; set; }
		public string? About { get; set; }
		public string? Location { get; set; } //مكان تواجد الدكتور 
		public List<Experience>? Experiences { get; set; }
		public List<Qualifications>? Qualifications { get; set; }
		public List<TimeSlots>? TimeSlots { get; set; }

        [Required(ErrorMessage = "The Ticket Price is Required")]
        public float TicketPrice { get; set; }

        [ForeignKey("Specialization")]
        [Required(ErrorMessage = "The Specialization Id is Required")]
        public int SpecializationId { get; set; }
        public Specialization? Specialization { get; set; }

        [ForeignKey("User")]
        [Required(ErrorMessage = "The User Id is Required")]
        public string userId { get; set; }
		public ApplicationUser? User { get; set; }


	}
}
