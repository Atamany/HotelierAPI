using HotelierAPI_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierAPI_BusinessLayer.Abstract
{
    public interface ISubscribeService
    {
        void TInsert(Subscribe t);
        void TDelete(Subscribe t);
        void TUpdate(Subscribe t);
        List<Subscribe> TGetList();
        Subscribe TGetById(int id);
    }
}
