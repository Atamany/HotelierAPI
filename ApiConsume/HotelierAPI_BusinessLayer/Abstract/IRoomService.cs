using HotelierAPI_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierAPI_BusinessLayer.Abstract
{
    public interface IRoomService
    {
        void TInsert(Room t);
        void TDelete(Room t);
        void TUpdate(Room t);
        List<Room> TGetList();
        Room TGetById(int id);
        int TGetRoomCount();
    }
}
