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
            AirlineCodeLookup = new AirlineCodeLookup.Client(http);
            AirportCitySearch = new AirportCitySearch.Client(http);
            AirportOnTimePerformance = new AirportOnTimePerformance.Client(http);
            FlightCheapestDateSearch = new FlightCheapestDateSearch.Client(http);
            FlightCheckInLinks = new FlightCheckInLinks.Client(http);
            FlightMostBookedDestinations = new FlightMostBookedDestinations.Client(http);
            FlightBusiestTravelingPeriod = new FlightBusiestTravelingPeriod.Client(http);
            FlightChoicePrediction = new FlightChoicePrediction.Client(http);
            FlightCreateOrders = new FlightCreateOrders.Client(http);
            FlightDelayPrediction = new FlightDelayPrediction.Client(http);
            FlightInspirationSearch = new FlightInspirationSearch.Client(http);
            FlightLowFareSearch = new FlightLowFareSearch.Client(http);
            FlightMostTraveledDestinations = new FlightMostTraveledDestinations.Client(http);
            FlightOffersSearch = new FlightOffersSearch.Client(http);
            FlightOrderManagement = new FlightOrderManagement.Client(http);
            NearestRelevantAirports = new NearestRelevantAirports.Client(http);
            SeatMapDisplay = new SeatMapDisplay.Client(http);

            if (isLive)
            {
                AirlineCodeLookup.BaseUrl = AirlineCodeLookup.BaseUrl.Replace("test.", "");
                AirportCitySearch.BaseUrl = AirportCitySearch.BaseUrl.Replace("test.", "");
                AirportOnTimePerformance.BaseUrl = AirportOnTimePerformance.BaseUrl.Replace("test.", "");
                FlightCheapestDateSearch.BaseUrl = FlightCheapestDateSearch.BaseUrl.Replace("test.", "");
                FlightCheckInLinks.BaseUrl = FlightCheckInLinks.BaseUrl.Replace("test.", "");
                FlightMostBookedDestinations.BaseUrl = FlightMostBookedDestinations.BaseUrl.Replace("test.", "");
                FlightBusiestTravelingPeriod.BaseUrl = FlightBusiestTravelingPeriod.BaseUrl.Replace("test.", "");
                FlightChoicePrediction.BaseUrl = FlightChoicePrediction.BaseUrl.Replace("test.", "");
                FlightCreateOrders.BaseUrl = FlightCreateOrders.BaseUrl.Replace("test.", "");
                FlightDelayPrediction.BaseUrl = FlightDelayPrediction.BaseUrl.Replace("test.", "");
                FlightInspirationSearch.BaseUrl = FlightInspirationSearch.BaseUrl.Replace("test.", "");
                FlightLowFareSearch.BaseUrl = FlightLowFareSearch.BaseUrl.Replace("test.", "");
                FlightMostTraveledDestinations.BaseUrl = FlightMostTraveledDestinations.BaseUrl.Replace("test.", "");
                FlightOffersSearch.BaseUrl = FlightOffersSearch.BaseUrl.Replace("test.", "");
                FlightOrderManagement.BaseUrl = FlightOrderManagement.BaseUrl.Replace("test.", "");
                NearestRelevantAirports.BaseUrl = NearestRelevantAirports.BaseUrl.Replace("test.", "");
                SeatMapDisplay.BaseUrl = SeatMapDisplay.BaseUrl.Replace("test.", "");
            }
        }
    }
}
