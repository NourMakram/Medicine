using System.ComponentModel.DataAnnotations;

namespace Medicine.Dtos
{
    public class QualificationDto
    {
        public int Id { get; set; }

        public DateTime? StartQualificationDate { get; set; }
        public DateTime? EndQualificationsDate { get; set; }
        [Required(ErrorMessage = "The Degree is Required")]
        public string Degree { get; set; }
        public string? University { get; set; }
    }
}
