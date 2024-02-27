﻿namespace HotelProject.WebUI.Dtos.AppUserDto
{
    public class ViewAppUserListWithLocationDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string WorkLocationName { get; set; }
        public string WorkLocationCity { get; set; }
        public int WorkLocationID { get; set; }

        public string City { get; set; }
        public string ImageUrl { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public bool Status { get; set; }
        public string WorkDepartment { get; set; }

    }
}
