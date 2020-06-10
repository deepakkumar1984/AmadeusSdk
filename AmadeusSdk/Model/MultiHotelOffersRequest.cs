using System;
using System.Collections.Generic;
using System.Text;

namespace AmadeusSdk.HotelSearch
{
    public class MultiHotelOffersRequest
    {
        public string CityCode { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public IEnumerable<string> HotelIds { get; set; }
        public System.DateTimeOffset? CheckInDate { get; set; }
        public System.DateTimeOffset? CheckOutDate { get; set; }
        public int? RoomQuantity { get; set; }
        public int? Adults { get; set; }
        public IEnumerable<int> ChildAges { get; set; }
        public int? Radius { get; set; }
        public RadiusUnit? RadiusUnit { get; set; }
        public string HotelName { get; set; }
        public IEnumerable<string> Chains { get; set; }
        public IEnumerable<string> RateCodes { get; set; }
        public IEnumerable<AmenitiyType> Amenities { get; set; }
        public IEnumerable<Rating> Ratings { get; set; }
        public string PriceRange { get; set; }
        public string Currency { get; set; }
        public PaymentPolicyType? PaymentPolicy { get; set; }
        public BoardType? BoardType { get; set; }
        public bool? IncludeClosed { get; set; }
        public bool? BestRateOnly { get; set; }
        public ViewType? View { get; set; }
        public SortBy? Sort { get; set; }
        public int? Pagelimit { get; set; }
        public string PageOffset { get; set; }
        public string Lang { get; set; }
    }
}
