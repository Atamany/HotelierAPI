using HotelierAPI_BusinessLayer.Abstract;
using HotelierAPI_DataAccessLayer.Abstract;
using HotelierAPI_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierAPI_BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TDelete(Testimonial t) => _testimonialDal.Delete(t);
        public Testimonial TGetById(int id) => _testimonialDal.GetById(id);
        public List<Testimonial> TGetList() => _testimonialDal.GetList();
        public void TInsert(Testimonial t) => _testimonialDal.Insert(t);
        public void TUpdate(Testimonial t) => _testimonialDal.Update(t);
    }
}
