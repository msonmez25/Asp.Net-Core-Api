﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void TDelete(Room t)
        {
            _roomDal.Delete(t);
        }

        public List<Room> TGet6RoomList()
        {
            return _roomDal.Get6RoomList();
        }

        public Room TGetByID(int id)
        {
           return _roomDal.GetByID(id);
        }

        public List<Room> TGetList()
        {
            return _roomDal.GetList();
        }

        public int TGetRoomCount()
        {
            return _roomDal.GetRoomCount();
        }

        public void TInsert(Room t)
        {
            _roomDal.Insert(t);
        }

        public void TUpdate(Room t)
        {
            _roomDal.Update(t);
        }
    }
}
