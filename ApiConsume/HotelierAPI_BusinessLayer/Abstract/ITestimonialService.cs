using HotelierAPI_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierAPI_BusinessLayer.Abstract
{
    public interface ITestimonialService
    {
        void TInsert(Testimonial t);
        void TDelete(Testimonial t);
        void TUpdate(Testimonial t);
        List<Testimonial> TGetList();
        Testimonial TGetById(int id);
    }
}
