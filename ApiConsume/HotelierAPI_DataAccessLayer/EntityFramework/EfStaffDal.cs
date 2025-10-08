using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelierAPI_DataAccessLayer.Abstract;
using HotelierAPI_DataAccessLayer.Concrete;
using HotelierAPI_DataAccessLayer.Repositories;
using HotelierAPI_EntityLayer.Concrete;

namespace HotelierAPI_DataAccessLayer.EntityFramework
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {
        }

        public int GetStaffCount()
        {
            using var context = new Context();
            var values = context.Staffs.Count();
            return values;
        }

        public List<Staff> Last4Staff()
        {
            
            using var context = new Context();
            return context.Staffs.OrderByDescending(x => x.StaffID).Take(4).ToList();
        }
    }
}
