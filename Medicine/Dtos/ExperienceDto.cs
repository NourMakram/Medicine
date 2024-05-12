using System.ComponentModel.DataAnnotations;

namespace Medicine.Dtos
{
    public class ExperienceDto
    {
        public int Id { get; set; }

        public DateOnly? StartExperienceDate { get; set; }
        public DateOnly? EndExperienceDate { get; set; }
        public string? Position { get; set; }

        [Required(ErrorMessage = "The Hospital is Required")]
        public string Hospital { get; set; }
    }
}
