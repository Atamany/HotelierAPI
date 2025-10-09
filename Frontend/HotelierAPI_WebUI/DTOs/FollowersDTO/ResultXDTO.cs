namespace HotelierAPI_WebUI.DTOs.FollowersDTO
{
    public class ResultXDTO
    {
        public Data data { get; set; }

        public class Data
        {
            public User user { get; set; }
        }

        public class User
        {
            public Result result { get; set; }
        }

        public class Result
        {
            public Legacy legacy { get; set; }
        }

        public class Legacy
        {
            public bool default_profile { get; set; }
            public bool default_profile_image { get; set; }
            public int fast_followers_count { get; set; }
            public int followers_count { get; set; }
            public int friends_count { get; set; }
            public string name { get; set; }
            public int normal_followers_count { get; set; }
            public string profile_banner_url { get; set; }
            public string profile_image_url_https { get; set; }
            public string screen_name { get; set; }

        }
    }
}
