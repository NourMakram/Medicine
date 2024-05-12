using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicine.Models
{
	public class Experience
	{
        [Required(ErrorMessage = "The Id is Required")]
        public int Id { get; set; }
		public DateOnly? St_date { get; set; }
		public DateOnly? En_date { get; set; }
		public string? Position { get; set; }

        [Required(ErrorMessage = "The Hospital is Required")]
        public string Hospital { get; set; }

		[ForeignKey("doctor")]
        [Required(ErrorMessage = "The Doctor is Required")]
        public int doctor_id { get; set; }
		public Doctor? doctor { get; set; }



	}
}

