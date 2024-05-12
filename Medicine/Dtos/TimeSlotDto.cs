using System.ComponentModel.DataAnnotations;

namespace Medicine.Dtos
{
    public class TimeSlotDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The Day is Required")]
        public string DayTimeSlot { get; set; }
        public TimeOnly? Form { get; set; }
        public TimeOnly? To { get; set; }
    }
}
