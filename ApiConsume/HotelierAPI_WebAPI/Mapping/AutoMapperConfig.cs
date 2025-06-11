using AutoMapper;
using HotelierAPI_DTOLayer.DTOs.RoomDTO;
using HotelierAPI_EntityLayer.Concrete;

namespace HotelierAPI_WebAPI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDTO, Room>().ReverseMap();
            CreateMap<RoomUpdateDTO, Room>().ReverseMap();
        }
    }
}
