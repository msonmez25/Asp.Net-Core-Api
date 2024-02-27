using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgetsController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly IAppUserService _appUserService;
        private readonly IWorkLocationService _workLocationService;
        private readonly IRoomService _roomService;
        private readonly ITestimonialService _testimonialService;
        private readonly IGuestService _guestService;
        private readonly IContactService _contactService;

        public DashboardWidgetsController(IStaffService staffService, IBookingService bookingService, IAppUserService appUserService, IWorkLocationService workLocationService, IRoomService roomService, IContactService contactService, IGuestService guestService, ITestimonialService testimonialService)
        {
            _staffService = staffService;
            _bookingService = bookingService;
            _appUserService = appUserService;
            _workLocationService = workLocationService;
            _roomService = roomService;
            _contactService = contactService;
            _guestService = guestService;
            _testimonialService = testimonialService;
        }


        [HttpGet("StaffCount")]
        public IActionResult StaffCount() 
        {
            var value = _staffService.TGetStaffCount();
            return Ok(value);
        }


        [HttpGet("BookingCount")]
        public IActionResult BookingCount()
        {
            var value = _bookingService.TGetBookingCount();
            return Ok(value);
        }

        [HttpGet("AppUserCount")]
        public IActionResult AppUserCount()
        {
            var value = _appUserService.TGetAppUserCount();
            return Ok(value);
        }

        [HttpGet("LocationCount")]
        public IActionResult LocationCount()
        {
            var value = _workLocationService.TGetLocationCount();
            return Ok(value);
        }


        [HttpGet("RoomCount")]
        public IActionResult RoomCount()
        {
            var value = _roomService.TGetRoomCount();
            return Ok(value);
        }


        [HttpGet("TestimonialCount")]
        public IActionResult TestimonialCount()
        {
            var value = _testimonialService.TGetTestimonialCount();
            return Ok(value);
        }


        [HttpGet("GuestCount")]
        public IActionResult GuestCount()
        {
            var value = _guestService.TGetGuestCount();
            return Ok(value);
        }


        [HttpGet("ContactCount")]
        public IActionResult ContactCount()
        {
            var value = _contactService.TGetContactCount();
            return Ok(value);
        }

    }
}
