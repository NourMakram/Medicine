using System.ComponentModel.DataAnnotations;

namespace Medicine.Dtos
{
    public class BasicDoctorData
    {
        [Required(ErrorMessage = "The DoctorName is Required")]
        public string DoctorName { get; set; }
        [Required(ErrorMessage = "The Email is Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "The Phone is Required")]
        public string Phone {  get; set; }
        [Required(ErrorMessage = "The Bio is Required")]

        public string Bio {  get; set; }
        [Required(ErrorMessage = "The Gender is Required")]

        public string Gender {  get; set; }
        [Required(ErrorMessage = "The About is Required")]
        public string About { get; set; }
        [Required(ErrorMessage = "The Ticket Price is Required")]
        public float TicketPrice { get; set; }
    }
}
