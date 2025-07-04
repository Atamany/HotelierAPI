﻿using HotelierAPI_BusinessLayer.Abstract;
using HotelierAPI_DataAccessLayer.Abstract;
using HotelierAPI_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierAPI_BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public void TDelete(Subscribe t) => _subscribeDal.Delete(t);
        public Subscribe TGetById(int id) => _subscribeDal.GetById(id);
        public List<Subscribe> TGetList() => _subscribeDal.GetList();
        public void TInsert(Subscribe t) => _subscribeDal.Insert(t);
        public void TUpdate(Subscribe t) => _subscribeDal.Update(t);
    }
}
