﻿using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IBookingService:IGenericService<Booking>
    {
        void TBookingStatusChangeApproved(Booking booking);
        void TBookingStatusChangeApproved2(int id);
        void TBookingStatusChangeCancel(int id);
        void TBookingStatusChangeWait(int id);

        public int TGetBookingCount();
        public List<Booking> TGetLast6BookingList();
    }
}
