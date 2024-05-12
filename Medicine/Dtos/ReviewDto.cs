using System.ComponentModel.DataAnnotations;

namespace Medicine.Dtos
{
    public class ReviewDto
    {
        [Required(ErrorMessage = "The stars number is Required")]
        public string Num_Stars { get; set; }
        public string? Message { get; set; }
        [Required(ErrorMessage = "The Doctor is Required")]
        public int DoctorId { get; set; }
        [Required(ErrorMessage = "The Patient is Required")]
        public int PatientId { get; set; }
    }
}
