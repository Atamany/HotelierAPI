using HotelierAPI_DataAccessLayer.Abstract;
using HotelierAPI_DataAccessLayer.Concrete;
using HotelierAPI_DataAccessLayer.Repositories;
using HotelierAPI_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierAPI_DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {
        }

        public void BookingStatusChangeApproved(Booking booking)
        {
            using var context = new Context();
            context.Bookings.Attach(booking);
            booking.Status = "Onaylandı!";
            context.SaveChanges();
        }

        public void BookingStatusChangeRejected(Booking booking)
        {
            using var context = new Context();
            context.Bookings.Attach(booking);
            booking.Status = "İptal Edildi!";
            context.SaveChanges();
        }

        public int GetBookingCount()
        {
            var context = new Context();
            return context.Bookings.Count();
        }

        public List<Booking> Last6Booking()
        {
            var context = new Context();
            return context.Bookings.OrderByDescending(x => x.BookingID).Take(6).ToList();
        }
    }
}
