using AmadeusSdk;
using System;

namespace BasicExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string client_id = "XXXXXX";
            string client_secret = "XXXXXX";

            //Generate access token usually valid for 1800 sec
            AuthClient authClient = new AuthClient(client_id, client_secret);
            var token = authClient.GenerateAccessToken();

            // Get token info to check expiry before generating another token
            token = authClient.GetTokenInfo(token.AccessToken);

            if(token.ExpiresIn > 0)
            {
                HotelClient hotelClient = new HotelClient(token.AccessToken);
                var hotelSearch = hotelClient.HotelSearch.GetMultiHotelOffersAsync("LON").Result;
            }
        }
    }
}
