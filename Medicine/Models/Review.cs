using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Models
{
	public class Review
	{
        [Required(ErrorMessage = "The Id is Required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "The stars number is Required")]
        public string Num_Satrt { get; set; }
		public string? Message { get; set; }

		[ForeignKey("doctor")]
        [Required(ErrorMessage = "The Doctor is Required")]
        public int doctor_id { get; set; }
		public Doctor? doctor { get; set; }

		[ForeignKey("patient")]
        [Required(ErrorMessage = "The Patient is Required")]
        public int Patient_id { get; set; }
		public Patient? patient { get; set; }
	}
}
