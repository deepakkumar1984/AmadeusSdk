using System;
using System.Collections.Generic;
using System.Text;

namespace AmadeusSdk
{
    public class DestinationClient
    {
        public PointsOfInterest.Client PointsOfInterest { get; set; }

        public DestinationClient(string authToken, bool isLive = false)
        {
            var http = new System.Net.Http.HttpClient();
            PointsOfInterest = new PointsOfInterest.Client(http);

            if (isLive)
            {
                PointsOfInterest.BaseUrl = PointsOfInterest.BaseUrl.Replace("test.", "");
            }
        }
    }
}
