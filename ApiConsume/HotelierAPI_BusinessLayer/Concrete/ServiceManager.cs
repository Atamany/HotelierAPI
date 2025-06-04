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
    public class ServiceManager : IServiceService
    {
        private readonly IServicesDal _serviceDal;

        public ServiceManager(IServicesDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TDelete(Service t) => _serviceDal.Delete(t);
        public Service TGetById(int id) => _serviceDal.GetById(id);
        public List<Service> TGetList() => _serviceDal.GetList();
        public void TInsert(Service t) => _serviceDal.Insert(t);
        public void TUpdate(Service t) => _serviceDal.Update(t);
    }
}
