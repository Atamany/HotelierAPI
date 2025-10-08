using HotelierAPI_DataAccessLayer.Abstract;
using HotelierAPI_DataAccessLayer.Concrete;
using HotelierAPI_DataAccessLayer.Repositories;
using HotelierAPI_EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierAPI_DataAccessLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context)
        {
        }

        public int GetAppUserCount()
        {
            var context = new Context();
            return context.Users.Count();
        }

        public List<AppUser> GetAppUsersWithWorkLocation()
        {
            using var context = new Context();
            return context.Users.Include(x=>x.WorkLocation).ToList();
        }
    }
}
