
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EFTestimonialDal : GenericRepository<Testimonial>,ITestimonialDal
    {
        public EFTestimonialDal(Context context):base(context) 
        {
            
        }

        public int GetTestimonialCount()
        {
            using var context = new Context();
            var value = context.Testimonials.Count();
            return value;
        }
    }
}
