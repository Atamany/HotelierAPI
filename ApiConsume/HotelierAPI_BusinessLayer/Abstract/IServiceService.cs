﻿using HotelierAPI_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierAPI_BusinessLayer.Abstract
{
    public interface IServiceService
    {
        void TInsert(Service t);
        void TDelete(Service t);
        void TUpdate(Service t);
        List<Service> TGetList();
        Service TGetById(int id);
    }
}
