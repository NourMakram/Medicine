using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Models
{
	public class Booking
	{
		public int Id { get; set; }

		[ForeignKey("Specialization")]
		[Required(ErrorMessage = "The  Specialization is Required")]
		public int Specialization_id { get; set; }
		public Specialization? Specialization { get; set; }

		[ForeignKey("doctor")]
        [Required(ErrorMessage = "The Doctor is Required")]

        public int doctor_id { get; set; }
		public Doctor? doctor { get; set; }

        [Required(ErrorMessage = "The Name is Required")]

        public string Name { get; set; }


		[ForeignKey("patient")]
        [Required(ErrorMessage = "The Patient is Required")]

        public int Patient_id { get; set; }
		public Patient? patient { get; set; }


		[ForeignKey("TimeSlots")]
        [Required(ErrorMessage = "The Appointment is Required")]
        public int DateTime { get; set; }
		public TimeSlots? TimeSlots { get; set; }


	}
}
