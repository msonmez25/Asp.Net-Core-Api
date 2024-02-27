namespace HotelProject.WebUI.Dtos.FollowersDto
{
    public class ViewLinkedinDto
    {


        public Data data { get; set; }


        public class Data
        {
            public int followers_count { get; set; }
            public int connections_count { get; set; }
        }



    }
}
