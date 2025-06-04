using HotelierAPI_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierAPI_BusinessLayer.Abstract
{
    public interface IStaffService
    {
        void TInsert(Staff t);
        void TDelete(Staff t);
        void TUpdate(Staff t);
        List<Staff> TGetList();
        Staff TGetById(int id);
    }
}
