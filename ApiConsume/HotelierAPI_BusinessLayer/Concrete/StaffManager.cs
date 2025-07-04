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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void TDelete(Staff t) => _staffDal.Delete(t);
        public Staff TGetById(int id) => _staffDal.GetById(id);
        public List<Staff> TGetList() => _staffDal.GetList();
        public void TInsert(Staff t) => _staffDal.Insert(t);
        public void TUpdate(Staff t) => _staffDal.Update(t);
    }

}
