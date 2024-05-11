using Medicine.Dtos;
using Medicine.Models;

namespace Medicine.Repository
{
    public interface Ibooking
    {
        public void AddBooking(Booking booking);
        public List<BookingSender> GetBookingListToDoctor(int doctor_id);
        public List<BookingSender> GetBookingListToPatient(int patient_id);

    }
}
