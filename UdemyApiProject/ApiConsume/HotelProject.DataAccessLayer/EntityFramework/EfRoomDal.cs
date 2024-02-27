using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfRoomDal:GenericRepository<Room>, IRoomDal 
    {
        public EfRoomDal(Context context):base(context)
        {
            
        }

        public List<Room> Get6RoomList()
        {
            using var context = new Context();
            var values = context.Rooms.OrderBy(x => x.RoomID).Take(6).ToList();
            return values;
        }

        public int GetRoomCount()
        {
            using var context = new Context();
            var value = context.Rooms.Count();
            return value;
        }
    }
    
}
