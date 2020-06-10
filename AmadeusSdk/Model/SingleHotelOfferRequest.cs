using System;
using System.Collections.Generic;
using System.Text;

namespace AmadeusSdk.HotelSearch
{
    public class SingleHotelOfferRequest
    {
        public string HotelId { get; set; }
        public DateTimeOffset? CheckInDate { get; set; }
        public DateTimeOffset? CheckOutDate { get; set; }
        public int? Adults { get; set; }
        public IEnumerable<int> ChildAges { get; set; }
        public IEnumerable<string> RateCodes { get; set; }
        public int? RoomQuantity { get; set; }
        public IEnumerable<Rating> Ratings { get; set; }
        public string Currency { get; set; }
        public PaymentPolicyType? PaymentPolicy { get; set; }
        public BoardType? BoardType { get; set; }
        public bool? IncludeClosed { get; set; }
        public bool? BestRateOnly { get; set; }
        public ViewType2? View { get; set; }
        public SortBy? Sort { get; set; }
        public string Lang { get; set; }
    }
}
