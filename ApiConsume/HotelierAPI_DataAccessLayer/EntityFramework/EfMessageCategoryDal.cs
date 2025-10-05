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
    public class EfMessageCategoryDal:GenericRepository<MessageCategory>, IMessageCategoryDal
    {
        public EfMessageCategoryDal(Context context) : base(context)
        {
        }
    }
}
