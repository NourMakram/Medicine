using Medicine.Dtos;
using Medicine.Models;
using Medicine.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medicine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        Ibooking BookingRepository;
        public BookingController(Ibooking _BookingRepository) {
            this.BookingRepository = _BookingRepository;
        }
        [HttpGet("GetBookingByDoctorId/{id:int}")]
        public ActionResult<List<BookingSender>> GetBookingByDoctorId(int id)
        {
            return this.BookingRepository.GetBookingListToDoctor(id);


        }
        [HttpGet("GetBookingByPatientId/{id:int}")]
        public ActionResult<List<BookingSender>> GetBookingByPatientIde(int id)
        {
            return this.BookingRepository.GetBookingListToPatient(id);


        }
        [HttpPost("AddBooking")]
        public IActionResult AddBooking(BookingRecived bookingRecived)
        {
            this.BookingRepository.AddBooking(new Booking()
            {
                doctor_id = bookingRecived.doctor_id,
                Patient_id = bookingRecived.patient_id,
                Name = bookingRecived.Name,
                DateTime= bookingRecived.timeslots_id,
                Specialization_id=bookingRecived.specilization_id

            }) ;
            return Ok("The Booking is Record succefluy");

        }

    }
}
