using AutoMapper;
using HotelierAPI_EntityLayer.Concrete;
using HotelierAPI_WebUI.DTOs.AboutDTO;
using HotelierAPI_WebUI.DTOs.AppUserDTO;
using HotelierAPI_WebUI.DTOs.BookingDTO;
using HotelierAPI_WebUI.DTOs.ContactDTO;
using HotelierAPI_WebUI.DTOs.GuestDTO;
using HotelierAPI_WebUI.DTOs.LoginDTO;
using HotelierAPI_WebUI.DTOs.RegisterDTO;
using HotelierAPI_WebUI.DTOs.ServiceDTO;
using HotelierAPI_WebUI.DTOs.StaffDTO;
using HotelierAPI_WebUI.DTOs.SubscribeDTO;

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
            CreateMap<ResultAboutDTO,About>().ReverseMap();
            CreateMap<UpdateAboutDTO,About>().ReverseMap();
            CreateMap<ResultStaffDTO,Staff>().ReverseMap();
            CreateMap<CreateSubscribeDTO,Subscribe>().ReverseMap();
            CreateMap<CreateBookingDTO, Booking>().ReverseMap();
            CreateMap<BookingApprovedDTO, Booking>().ReverseMap();
            CreateMap<BookingRejectedDTO, Booking>().ReverseMap();
            CreateMap<CreateContactDTO, Contact>().ReverseMap();
            CreateMap<CreateGuestDTO, Guest>().ReverseMap();
            CreateMap<UpdateGuestDTO, Guest>().ReverseMap();
            CreateMap<ResultAppUserDTO, AppUser>().ReverseMap();

        }
    }
}
