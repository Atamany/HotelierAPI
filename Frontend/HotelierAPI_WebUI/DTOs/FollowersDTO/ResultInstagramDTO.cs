namespace HotelierAPI_WebUI.DTOs.FollowersDTO
{
    public class ResultInstagramDTO
    {
        public Data data { get; set; }

        public class Data
        {
            public string full_name { get; set; }
            public string pk_id { get; set; }
            public int following_count { get; set; }
            public int follower_count { get; set; }
            public string profile_pic_url { get; set; }
            public string username { get; set; }
        }
    }
}
