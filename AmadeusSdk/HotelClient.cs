using System;
using System.Collections.Generic;
using System.Text;

namespace AmadeusSdk
{
    public class HotelClient
    {
        public HotelBooking.Client HotelBooking { get; set; }
        public HotelRatings.Client HotelRatings { get; set; }
        public HotelSearch.Client HotelSearch { get; set; }

        public bool IsLive { get; set; }

        public HotelClient(string authToken, bool isLive = false)
        {
            var http = new System.Net.Http.HttpClient();
            http.DefaultRequestHeaders.Add("Authorization", $"Bearer {authToken}");

            HotelBooking = new HotelBooking.Client(http);
            HotelRatings = new HotelRatings.Client(http);
            HotelSearch = new HotelSearch.Client(http);

            if(isLive)
            {
                HotelBooking.BaseUrl = HotelBooking.BaseUrl.Replace("test.", "");
                HotelRatings.BaseUrl = HotelRatings.BaseUrl.Replace("test.", "");
                HotelSearch.BaseUrl = HotelSearch.BaseUrl.Replace("test.", "");
            }
        }
    }
}
