using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactWithCategoryController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactWithCategoryController(IContactService contactService)
        {
            _contactService = contactService;
        }


        [HttpGet]
        public IActionResult Index()
        {
            Context context = new Context();
            var values = context.Contacts.Include(x => x.MessageCategory).Select(y=> new ContactWithCategoryViewModel
            {
                ContactID = y.ContactID,
                Name = y.Name,
                Mail = y.Mail,
                Subject = y.Subject,
                Message = y.Message,
                Date = y.Date,
                MessageCategoryID = y.MessageCategoryID,
                MessageCategoryName = y.MessageCategory.MessageCategoryName                

            }).ToList();
            return Ok(values);
        }
    }
}
