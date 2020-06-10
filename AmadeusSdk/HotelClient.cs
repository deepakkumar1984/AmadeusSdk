using AmadeusSdk.HotelSearch;
using AmadeusSdk.HotelRatings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AmadeusSdk.HotelBooking;

namespace AmadeusSdk
{
    public class HotelClient
    {
        internal HotelBooking.Client HotelBooking { get; set; }
        internal HotelRatings.Client HotelRatings { get; set; }
        internal HotelSearch.Client HotelSearch { get; set; }

        public bool IsLive { get; set; }

        public HotelClient(string authToken, bool isLive = false)
        {
            var http = new System.Net.Http.HttpClient();
            var httpV1 = new System.Net.Http.HttpClient();
            if(isLive)
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

            HotelBooking = new HotelBooking.Client(httpV1);
            HotelRatings = new HotelRatings.Client(http);
            HotelSearch = new HotelSearch.Client(http);
        }

        public Task<HotelSearch.MultiHotelOffersResponse> GetMultiHotelOffersAsync(MultiHotelOffersRequest request)
        {
            return HotelSearch.GetMultiHotelOffersAsync(request.CityCode, request.Latitude, request.Longitude, request.HotelIds, request.CheckInDate, request.CheckOutDate, request.RoomQuantity, request.Adults, request.ChildAges, request.Radius, request.RadiusUnit, request.HotelName, request.Chains, request.RateCodes, request.Amenities, request.Ratings, request.PriceRange, request.Currency, request.PaymentPolicy, request.BoardType, request.IncludeClosed, request.BestRateOnly, request.View, request.Sort, request.Pagelimit, request.PageOffset, request.Lang, System.Threading.CancellationToken.None);
        }

        public Task<SingleHotelOffersResponse> GetSingleHotelOffersAsync(SingleHotelOfferRequest request)
        {
            return HotelSearch.GetSingleHotelOffersAsync(request.HotelId, request.CheckInDate, request.CheckOutDate, request.Adults, request.ChildAges, request.RateCodes, request.RoomQuantity, request.Currency, request.PaymentPolicy, request.BoardType, request.View, request.Lang, System.Threading.CancellationToken.None);
        }

        public Task<SingleHotelOffersResponse> GetOfferPricingAsync(string offerId, string lang)
        {
            return HotelSearch.GetOfferPricingAsync(offerId, lang, System.Threading.CancellationToken.None);
        }

        public Task<SuccessSentiments> GetSentimentsByHotelIdsAsync(params string[] hotelIds)
        {
            if(hotelIds.Length > 0)
                return HotelRatings.GetSentimentsByHotelIdsAsync(hotelIds, System.Threading.CancellationToken.None);

            return null;
        }

        public Task<HotelBookedResponse> CreateBookingAsync(BookingSchema requestBody, string ama_Client_Ref, AcceptEncoding? accept_Encoding)
        {
            return HotelBooking.CreateBookingAsync(requestBody, ama_Client_Ref, accept_Encoding, System.Threading.CancellationToken.None);
        }
    }
}
