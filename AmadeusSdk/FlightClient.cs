using System;

namespace AmadeusSdk
{
    public class FlightClient
    {
        public AirlineCodeLookup.Client AirlineCodeLookup { get; set; }
        public AirportCitySearch.Client AirportCitySearch { get; set; }
        public AirportOnTimePerformance.Client AirportOnTimePerformance { get; set; }
        public FlightCheapestDateSearch.Client FlightCheapestDateSearch { get; set; }
        public FlightCheckInLinks.Client FlightCheckInLinks { get; set; }
        public FlightMostBookedDestinations.Client FlightMostBookedDestinations { get; set; }
        public FlightBusiestTravelingPeriod.Client FlightBusiestTravelingPeriod { get; set; }
        public FlightChoicePrediction.Client FlightChoicePrediction { get; set; }
        public FlightCreateOrders.Client FlightCreateOrders { get; set; }
        public FlightDelayPrediction.Client FlightDelayPrediction { get; set; }
        public FlightInspirationSearch.Client FlightInspirationSearch { get; set; }
        public FlightLowFareSearch.Client FlightLowFareSearch { get; set; }
        public FlightMostTraveledDestinations.Client FlightMostTraveledDestinations { get; set; }
        public FlightOffersSearch.Client FlightOffersSearch { get; set; }
        public FlightOrderManagement.Client FlightOrderManagement { get; set; }
        public NearestRelevantAirports.Client NearestRelevantAirports { get; set; }
        public SeatMapDisplay.Client SeatMapDisplay { get; set; }

        public FlightClient(string authToken, bool isLive = false)
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

            AirlineCodeLookup = new AirlineCodeLookup.Client(httpV1);
            AirportCitySearch = new AirportCitySearch.Client(httpV1);
            AirportOnTimePerformance = new AirportOnTimePerformance.Client(httpV1);
            FlightCheapestDateSearch = new FlightCheapestDateSearch.Client(httpV1);
            FlightCheckInLinks = new FlightCheckInLinks.Client(http);
            FlightMostBookedDestinations = new FlightMostBookedDestinations.Client(httpV1);
            FlightBusiestTravelingPeriod = new FlightBusiestTravelingPeriod.Client(httpV1);
            FlightChoicePrediction = new FlightChoicePrediction.Client(http);
            FlightCreateOrders = new FlightCreateOrders.Client(httpV1);
            FlightDelayPrediction = new FlightDelayPrediction.Client(httpV1);
            FlightInspirationSearch = new FlightInspirationSearch.Client(httpV1);
            FlightLowFareSearch = new FlightLowFareSearch.Client(httpV1);
            FlightMostTraveledDestinations = new FlightMostTraveledDestinations.Client(httpV1);
            FlightOffersSearch = new FlightOffersSearch.Client(http);
            FlightOrderManagement = new FlightOrderManagement.Client(httpV1);
            NearestRelevantAirports = new NearestRelevantAirports.Client(httpV1);
            SeatMapDisplay = new SeatMapDisplay.Client(httpV1);
        }
    }
}
