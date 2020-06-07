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

        public TripClient(string authToken, bool isLive = false)
        {
            var http = new System.Net.Http.HttpClient();
            AIGeneratedPhotos = new AIGeneratedPhotos.Client(http);
            TripParser = new TripParser.Client(http);
            TripPurposePrediction = new TripPurposePrediction.Client(http);

            if (isLive)
            {
                AIGeneratedPhotos.BaseUrl = AIGeneratedPhotos.BaseUrl.Replace("test.", "");
                TripParser.BaseUrl = TripParser.BaseUrl.Replace("test.", "");
                TripPurposePrediction.BaseUrl = TripPurposePrediction.BaseUrl.Replace("test.", "");
            }
        }
    }
}
