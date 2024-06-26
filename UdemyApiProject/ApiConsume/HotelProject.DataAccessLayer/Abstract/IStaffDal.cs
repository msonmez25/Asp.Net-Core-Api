﻿using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IStaffDal:IGenericDal<Staff>
    {
        public int GetStaffCount();

        public List<Staff> GetLast4StaffList();
        public List<Staff> Get8StaffList();
    }
}
