using HotelierAPI_BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelierAPI_EntityLayer.Concrete;
using HotelierAPI_DataAccessLayer.Abstract;

namespace HotelierAPI_BusinessLayer.Concrete
{
    public class RoomManager : IRoomService<Room>
    {
        private readonly IRoomDal _roomDal;
        public void TDelete(Room t)
        {
            _roomDal.Delete(t);
        }

        public Room TGetById(int id)
        {
            return _roomDal.GetById(id);
        }

        public List<Room> TGetList()
        {
            return _roomDal.GetList();
        }

        public void TInsert(Room t)
        {
            _roomDal.Insert(t);
        }

        public void TUpdate(Room t)
        {
            _roomDal.Update(t);
        }
    }
}
