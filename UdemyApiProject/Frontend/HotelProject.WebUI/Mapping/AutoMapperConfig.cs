using AutoMapper;
using HotelProject.DataAccessLayer.Migrations;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.RoomDto;
using HotelProject.WebUI.Dtos.SubscribeDto;
using HotelProject.WebUI.Dtos.TestimonialDto;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.Dtos.WorkLocation;
using HotelProject.WebUI.Dtos.AppUserDto;
using HotelProject.WebUI.Models.Setting;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
           CreateMap<ViewServiceDto, Service>().ReverseMap();
           CreateMap<UpdateServiceDto, Service>().ReverseMap();
           CreateMap<AddServiceDto, Service>().ReverseMap();

            CreateMap<AddRegisterDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ViewAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ViewTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ViewRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
            CreateMap<AddRoomDto, Room>().ReverseMap();

            CreateMap<ViewGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();
            CreateMap<AddGuestDto, Guest>().ReverseMap();

            CreateMap<AddSubscribeDto, Subscribe>().ReverseMap();

            CreateMap<AddBookingDto, Booking>().ReverseMap();
            CreateMap<ApprovedReservationBookingDto, Booking>().ReverseMap();

            CreateMap<ViewWorkLocationDto, WorkLocation>().ReverseMap();
            CreateMap<UpdateWorkLocationDto, WorkLocation>().ReverseMap();
            CreateMap<AddWorkLocationDto, WorkLocation>().ReverseMap();

            CreateMap<ViewAppUserDto, AppUser>().ReverseMap();
            CreateMap<ViewAppUserListDto, AppUser>().ReverseMap();
            CreateMap<ViewAppUserListWithLocationDto, AppUser>().ReverseMap();


           
        }

    }
}
