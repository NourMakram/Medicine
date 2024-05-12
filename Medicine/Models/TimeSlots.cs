using System.ComponentModel.DataAnnotations;

namespace Medicine.Models
{
	public class TimeSlots
	{
        [Required(ErrorMessage = "The Id is Required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "The Day is Required")]
        public string Day { get; set; }
		public TimeOnly? Form { get; set; }
		public TimeOnly? To { get; set; }


	}
}
