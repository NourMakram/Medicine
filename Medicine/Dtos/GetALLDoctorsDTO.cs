using System.ComponentModel.DataAnnotations;

namespace Medicine.Dtos
{
    public class GetALLDoctorsDTO
    {
        [Required(ErrorMessage = "The Id is Required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "The Basic Doctor Data is Required")]
        public BasicDoctorData BasicInfo { get; set; }
        [Required(ErrorMessage = "The Specialization Name is Required")]
        public string SpecializationName { get; set; }
        [Required(ErrorMessage = "The Qualifications is Required")]
        public List<QualificationDto> Qualifications { get; set; }
        [Required(ErrorMessage = "The Experiences is Required")]
        public List<ExperienceDto> Experiences { get; set; }
        [Required(ErrorMessage = "The TimeSlots is Required")]
        public List<TimeSlotDto> TimeSlots { get; set; }
    }
}
