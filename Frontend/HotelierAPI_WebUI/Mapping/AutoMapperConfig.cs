﻿using AutoMapper;
using HotelierAPI_EntityLayer.Concrete;
using HotelierAPI_WebUI.DTOs.LoginDTO;
using HotelierAPI_WebUI.DTOs.RegisterDTO;
using HotelierAPI_WebUI.DTOs.ServiceDTO;

namespace HotelierAPI_WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDTO, Service>().ReverseMap();
            CreateMap<UpdateServiceDTO, Service>().ReverseMap();
            CreateMap<CreateServiceDTO, Service>().ReverseMap();
            CreateMap<CreateNewUserDTO,AppUser>().ReverseMap();
            CreateMap<LoginUserDTO,AppUser>().ReverseMap();

        }
    }
}
