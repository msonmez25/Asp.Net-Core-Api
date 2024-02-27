namespace HotelProject.WebUI.Dtos.FollowersDto
{
    public class ViewInstagramDto
    {

        //public string username { get; set; }
        //public string full_name { get; set; }
        //public int followers { get; set; }
        //public int following { get; set; }
        //public string profile_pic_url { get; set; }



        
            public Data data { get; set; }
        

        public class Data
        {
            public Edge_Followed_By edge_followed_by { get; set; }
           
            public Edge_Follow edge_follow { get; set; }
          
           
        }


        public class Edge_Followed_By
        {
            public int count { get; set; }
        }

        public class Edge_Follow
        {
            public int count { get; set; }
        }

      



    }
}
