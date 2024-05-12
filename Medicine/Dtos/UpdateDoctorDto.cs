using System.ComponentModel.DataAnnotations;

namespace Medicine.Dtos
{
    public class UpdateDoctorDto
    {
        [Required(ErrorMessage = "The Basic Doctor Data is Required")]
        public BasicDoctorData BasicInfo { get; set; }
        [Required(ErrorMessage = "The Specialization Id is Required")]
        public int SpecializationId { get; set; }
        public string? ImageUrl { get; set; }

        //[NotMapped]
         public IFormFile? ImageFile { get; set; }
        public List<QualificationDto>? Qualifications { get; set; }
        public List<ExperienceDto>? Experiences { get; set; }
        public List<TimeSlotDto>? TimeSlots { get; set; }
    }
}
