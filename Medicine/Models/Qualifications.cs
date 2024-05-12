using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Models
{
	public class Qualifications
	{
        [Required(ErrorMessage = "The Id is Required")]

        public int Id { get; set; }
		public DateTime? St_date { get; set; }
		public DateTime? En_date { get; set; }
        [Required(ErrorMessage = "The Degree is Required")]
        public string? Degree { get; set; }
		public string? University { get; set; }

		[ForeignKey("doctor")]

        [Required(ErrorMessage = "The Doctor is Required")]
        public int doctor_id { get; set; }
		public Doctor? doctor { get; set; }

	}
}
