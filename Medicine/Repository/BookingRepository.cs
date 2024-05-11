using Medicine.Dtos;
using Medicine.Models;
using Microsoft.EntityFrameworkCore;

namespace Medicine.Repository
{
    public class BookingRepository : Ibooking
    {
        public ApplicationDbContext Context;
       public BookingRepository(ApplicationDbContext _dbContext)
        {
            Context = _dbContext;

        }
        public void AddBooking(Booking booking)
        {
            this.Context.Bookings.Add(booking);
            this.Context.SaveChanges();
        }

        public List<BookingSender> GetBookingListToDoctor(int doctor_id)
        {
            return this.Context.Bookings
                .Where(b => b.doctor_id == doctor_id)
                 .Include(b => b.doctor)
                 .Include(b => b.patient)
                 .Select(b => new BookingSender()
                 {
                     doctorName = b.doctor.User.UserName,
                     patientName = b.patient.User.UserName,
                     day = b.doctor.TimeSlots[0].Day,
                     from = b.TimeSlots.Form,
                     to = b.TimeSlots.To,
                 })
            .ToList();
        }

        public List<BookingSender> GetBookingListToPatient(int patient_id)
        {
            return this.Context.Bookings
                           .Where(b => b.Patient_id == patient_id)
                            .Include(b => b.doctor)
                            .Include(b => b.patient)
                            .Select(b => new BookingSender()
                            {
                                doctorName = b.doctor.User.UserName,
                                patientName = b.patient.User.UserName,
                                day = b.doctor.TimeSlots[0].Day,
                                from = b.TimeSlots.Form,
                                to = b.TimeSlots.To,
                            })
                       .ToList();
        }
    }
}
