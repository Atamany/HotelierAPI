using HotelierAPI_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierAPI_BusinessLayer.Abstract
{
    public interface IAppUserService:IGenericService<AppUser>
    {
        public List<AppUser> TGetAppUsersWithWorkLocation();
    }
}
