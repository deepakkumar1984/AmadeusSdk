using System;
using System.Collections.Generic;
using System.Text;

namespace AmadeusSdk
{
    public class TripClient
    {
        public AIGeneratedPhotos.Client AIGeneratedPhotos { get; set; }
        public TripParser.Client TripParser { get; set; }
        public TripPurposePrediction.Client TripPurposePrediction { get; set; }
        public PointsOfInterest.Client PointsOfInterest { get; set; }
        public TripClient(string authToken, bool isLive = false)
        {
            var http = new System.Net.Http.HttpClient();
            var httpV1 = new System.Net.Http.HttpClient();
            if (isLive)
            {
                http.BaseAddress = new Uri("https://api.amadeus.com/v2/");
                httpV1.BaseAddress = new Uri("https://api.amadeus.com/v1/");
            }
            else
            {
                http.BaseAddress = new Uri("https://test.api.amadeus.com/v2/");
                httpV1.BaseAddress = new Uri("https://test.api.amadeus.com/v1/");
            }

            http.DefaultRequestHeaders.Add("Authorization", $"Bearer {authToken}");
            httpV1.DefaultRequestHeaders.Add("Authorization", $"Bearer {authToken}");
            AIGeneratedPhotos = new AIGeneratedPhotos.Client(http);
            TripParser = new TripParser.Client(http);
            TripPurposePrediction = new TripPurposePrediction.Client(httpV1);
            PointsOfInterest = new PointsOfInterest.Client(httpV1);
        }
    }
}
