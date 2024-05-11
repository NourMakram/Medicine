using Medicine.Models;
using System.ComponentModel.DataAnnotations;

namespace Medicine.Dtos
{
    public class BookingRecived
    {

        [Required(ErrorMessage = "The  patientid is Required")]

        public int patient_id { get; set; }
        [Required(ErrorMessage = "The  doctorid is Required")]

        public int doctor_id { get;set; }
        [Required(ErrorMessage = "The  specilizationid is Required")]
        public int specilization_id { get; set; }
        [Required(ErrorMessage = "The  Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The  timeslotsid is Required")]
        public int timeslots_id { get; set; }

    }
}
