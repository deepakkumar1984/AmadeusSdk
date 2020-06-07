﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v12.0.15.0 (NJsonSchema v9.13.22.0 (Newtonsoft.Json v12.0.0.2)) (http://NSwag.org)
// </auto-generated>
//----------------------

namespace AmadeusSdk.NearestRelevantAirports
{
    #pragma warning disable

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.0.15.0 (NJsonSchema v9.13.22.0 (Newtonsoft.Json v12.0.0.2))")]
    public partial class Client 
    {
        internal string _baseUrl = "https://test.api.amadeus.com/v1";
        private System.Net.Http.HttpClient _httpClient;
        private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;
    
        public Client(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient; 
            _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(() => 
            {
                var settings = new Newtonsoft.Json.JsonSerializerSettings();
                UpdateJsonSerializerSettings(settings);
                return settings;
            });
        }
    
        public string BaseUrl 
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }
    
        protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }
    
        partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);
    
        /// <summary>Returns a list of relevant airports near to a given point.</summary>
        /// <param name="latitude">latitude location to be at the center of the search circle</param>
        /// <param name="longitude">longitude location to be at the center of the search circle</param>
        /// <param name="radius">radius of the search in Kilometer. Can be from 0 to 500, default value is 500 Km.</param>
        /// <param name="pagelimit">maximum items in one page</param>
        /// <param name="pageoffset">start index of the requested page</param>
        /// <param name="sort">defines on which attribute the sorting will be done from the best option to the worst one:
        /// * **relevance** - Score value calculated based on distance and traffic analytics
        /// * distance - Distance from the location to the geo-code given in API request parameters
        /// * analytics.flights.score - Approximate score for ranking purposes calculated based on estimated number of flights from/to airport in one reference year (last year)
        /// * analytics.travelers.score - Approximate score for ranking purposes calculated based on estimated number of travelers in the airport for one reference year (last year)</param>
        /// <returns>Successful Operation</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Response> GetNearestRelevantAirportsAsync(double latitude, double longitude, int? radius, int? pagelimit, int? pageoffset, Sort? sort)
        {
            return GetNearestRelevantAirportsAsync(latitude, longitude, radius, pagelimit, pageoffset, sort, System.Threading.CancellationToken.None);
        }
    
        /// <summary>Returns a list of relevant airports near to a given point.</summary>
        /// <param name="latitude">latitude location to be at the center of the search circle</param>
        /// <param name="longitude">longitude location to be at the center of the search circle</param>
        /// <param name="radius">radius of the search in Kilometer. Can be from 0 to 500, default value is 500 Km.</param>
        /// <param name="pagelimit">maximum items in one page</param>
        /// <param name="pageoffset">start index of the requested page</param>
        /// <param name="sort">defines on which attribute the sorting will be done from the best option to the worst one:
        /// * **relevance** - Score value calculated based on distance and traffic analytics
        /// * distance - Distance from the location to the geo-code given in API request parameters
        /// * analytics.flights.score - Approximate score for ranking purposes calculated based on estimated number of flights from/to airport in one reference year (last year)
        /// * analytics.travelers.score - Approximate score for ranking purposes calculated based on estimated number of travelers in the airport for one reference year (last year)</param>
        /// <returns>Successful Operation</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<Response> GetNearestRelevantAirportsAsync(double latitude, double longitude, int? radius, int? pagelimit, int? pageoffset, Sort? sort, System.Threading.CancellationToken cancellationToken)
        {
            if (latitude == null)
                throw new System.ArgumentNullException("latitude");
    
            if (longitude == null)
                throw new System.ArgumentNullException("longitude");
    
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/reference-data/locations/airports?");
            urlBuilder_.Append("latitude=").Append(System.Uri.EscapeDataString(ConvertToString(latitude, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Append("longitude=").Append(System.Uri.EscapeDataString(ConvertToString(longitude, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            if (radius != null) 
            {
                urlBuilder_.Append("radius=").Append(System.Uri.EscapeDataString(ConvertToString(radius, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (pagelimit != null) 
            {
                urlBuilder_.Append("page[limit]=").Append(System.Uri.EscapeDataString(ConvertToString(pagelimit, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (pageoffset != null) 
            {
                urlBuilder_.Append("page[offset]=").Append(System.Uri.EscapeDataString(ConvertToString(pageoffset, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (sort != null) 
            {
                urlBuilder_.Append("sort=").Append(System.Uri.EscapeDataString(ConvertToString(sort, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;
    
            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/vnd.amadeus+json"));
    
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
    
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }
    
                        ProcessResponse(client_, response_);
    
                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200") 
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(Response); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<Response>(responseData_, _settings.Value);
                                return result_; 
                            } 
                            catch (System.Exception exception_) 
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ == "400") 
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(Error_400); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<Error_400>(responseData_, _settings.Value);
                            } 
                            catch (System.Exception exception_) 
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                            throw new SwaggerException<Error_400>("code    | title                                 \n------- | ------------------------------------- \n477     | INVALID FORMAT\n572     | INVALID OPTION\n4926    | INVALID DATA RECEIVED               \n32171   | MANDATORY DATA MISSING \t     \n", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
                            var result_ = default(Error_500); 
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<Error_500>(responseData_, _settings.Value);
                            } 
                            catch (System.Exception exception_) 
                            {
                                throw new SwaggerException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                            throw new SwaggerException<Error_500>("Unexpected Error", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }
    
        private string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value is System.Enum)
            {
                string name = System.Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute)) 
                            as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value;
                        }
                    }
                }
            }
            else if (value is bool) {
                return System.Convert.ToString(value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return System.Convert.ToBase64String((byte[]) value);
            }
            else if (value != null && value.GetType().IsArray)
            {
                var array = System.Linq.Enumerable.OfType<object>((System.Array) value);
                return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }
        
            return System.Convert.ToString(value, cultureInfo);
        }
    }
    
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.22.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Location 
    {
        /// <summary>the resource name</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }
    
        /// <summary>location sub type</summary>
        [Newtonsoft.Json.JsonProperty("subType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LocationSubType? SubType { get; set; }
    
        /// <summary>short name of the location</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        /// <summary>detailed name of the location. For a city location it contains city name and country code. For an airport location it contains city name; country code and airport full name</summary>
        [Newtonsoft.Json.JsonProperty("detailedName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DetailedName { get; set; }
    
        /// <summary>timezone offset of the location at the date of the API call (including daylight saving time)</summary>
        [Newtonsoft.Json.JsonProperty("timeZoneOffset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TimeZoneOffset { get; set; }
    
        /// <summary>IATA code of the location. ([IATA table codes](http://www.iata.org/publications/Pages/code-search.aspx) here)</summary>
        [Newtonsoft.Json.JsonProperty("iataCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IataCode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("geoCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GeoCode GeoCode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Address { get; set; }
    
        [Newtonsoft.Json.JsonProperty("distance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Distance Distance { get; set; }
    
        [Newtonsoft.Json.JsonProperty("analytics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Analytics Analytics { get; set; }
    
        /// <summary>score value calculated based on distance and analytics</summary>
        [Newtonsoft.Json.JsonProperty("relevance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Relevance { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Location FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Location>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.22.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Address 
    {
        /// <summary>name of the city of the location; equal to name if the location is a city</summary>
        [Newtonsoft.Json.JsonProperty("cityName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CityName { get; set; }
    
        /// <summary>IATA code of the city of the location; equal to IATAcode if the location is a city</summary>
        [Newtonsoft.Json.JsonProperty("cityCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CityCode { get; set; }
    
        /// <summary>name of the country of the location</summary>
        [Newtonsoft.Json.JsonProperty("countryName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CountryName { get; set; }
    
        /// <summary>code of the country of the location in ISO standard</summary>
        [Newtonsoft.Json.JsonProperty("countryCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CountryCode { get; set; }
    
        /// <summary>code of the state of the location if any</summary>
        [Newtonsoft.Json.JsonProperty("stateCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StateCode { get; set; }
    
        /// <summary>code of the region of the location in ISO standard</summary>
        [Newtonsoft.Json.JsonProperty("regionCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegionCode { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Address FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Address>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.22.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Distance 
    {
        /// <summary>great-circle distance between two locations. This distance thus do not take into account traffic conditions; international boundaries; mountains; water; or other elements that might make the a nearby location hard to reach.</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Value { get; set; }
    
        /// <summary>unit of the distance</summary>
        [Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DistanceUnit? Unit { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Distance FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Distance>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.22.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class GeoCode 
    {
        /// <summary>latitude of the location</summary>
        [Newtonsoft.Json.JsonProperty("latitude", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Latitude { get; set; }
    
        /// <summary>longitude of the location</summary>
        [Newtonsoft.Json.JsonProperty("longitude", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Longitude { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static GeoCode FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GeoCode>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.22.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Analytics 
    {
        [Newtonsoft.Json.JsonProperty("flights", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Flights Flights { get; set; }
    
        [Newtonsoft.Json.JsonProperty("travelers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Travelers Travelers { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Analytics FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Analytics>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.22.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Flights 
    {
        /// <summary>Approximate score for ranking purposes calculated based on number of flights from / to the airport or city</summary>
        [Newtonsoft.Json.JsonProperty("score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Score { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Flights FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Flights>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.22.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Travelers 
    {
        /// <summary>Approximate score for ranking purposes calculated based on number of travelers in the location.</summary>
        [Newtonsoft.Json.JsonProperty("score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Score { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Travelers FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Travelers>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.22.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Error_400 
    {
        [Newtonsoft.Json.JsonProperty("errors", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<Issue> Errors { get; set; } = new System.Collections.ObjectModel.Collection<Issue>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Error_400 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Error_400>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.22.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Error_500 
    {
        [Newtonsoft.Json.JsonProperty("errors", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<Issue> Errors { get; set; } = new System.Collections.ObjectModel.Collection<Issue>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Error_500 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Error_500>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.22.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Issue 
    {
        /// <summary>the HTTP status code applicable to this error</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Status { get; set; }
    
        /// <summary>an application-specific error code</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Code { get; set; }
    
        /// <summary>a short summary of the error</summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }
    
        /// <summary>explanation of the error</summary>
        [Newtonsoft.Json.JsonProperty("detail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Detail { get; set; }
    
        /// <summary>an object containing references to the source of the error</summary>
        [Newtonsoft.Json.JsonProperty("source", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Source Source { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Issue FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Issue>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.22.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Collection_Meta 
    {
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Count { get; set; }
    
        [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Links Links { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Collection_Meta FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Collection_Meta>(data);
        }
    
    }
    
    /// <summary>defines on which attribute the sorting will be done from the best option to the worst one:
    /// * **relevance** - Score value calculated based on distance and traffic analytics
    /// * distance - Distance from the location to the geo-code given in API request parameters
    /// * analytics.flights.score - Approximate score for ranking purposes calculated based on estimated number of flights from/to airport in one reference year (last year)
    /// * analytics.travelers.score - Approximate score for ranking purposes calculated based on estimated number of travelers in the airport for one reference year (last year)
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.22.0 (Newtonsoft.Json v12.0.0.2)")]
    public enum Sort
    {
        [System.Runtime.Serialization.EnumMember(Value = @"relevance")]
        Relevance = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"distance")]
        Distance = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"analytics.flights.score")]
        Analytics_flights_score = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"analytics.travelers.score")]
        Analytics_travelers_score = 3,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.22.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Response 
    {
        [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Collection_Meta Meta { get; set; }
    
        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<Location> Data { get; set; } = new System.Collections.ObjectModel.Collection<Location>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Response FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Response>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.22.0 (Newtonsoft.Json v12.0.0.2)")]
    public enum LocationSubType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"AIRPORT")]
        AIRPORT = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CITY")]
        CITY = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.22.0 (Newtonsoft.Json v12.0.0.2)")]
    public enum DistanceUnit
    {
        [System.Runtime.Serialization.EnumMember(Value = @"KM")]
        KM = 0,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.22.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Source 
    {
        /// <summary>a JSON Pointer [RFC6901] to the associated entity in the request document</summary>
        [Newtonsoft.Json.JsonProperty("pointer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pointer { get; set; }
    
        /// <summary>a string indicating which URI query parameter caused the issue</summary>
        [Newtonsoft.Json.JsonProperty("parameter", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Parameter { get; set; }
    
        /// <summary>a string indicating an example of the right value</summary>
        [Newtonsoft.Json.JsonProperty("example", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Example { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Source FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Source>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.22.0 (Newtonsoft.Json v12.0.0.2)")]
    public partial class Links 
    {
        [Newtonsoft.Json.JsonProperty("self", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Uri Self { get; set; }
    
        [Newtonsoft.Json.JsonProperty("next", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Uri Next { get; set; }
    
        [Newtonsoft.Json.JsonProperty("previous", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Uri Previous { get; set; }
    
        [Newtonsoft.Json.JsonProperty("last", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Uri Last { get; set; }
    
        [Newtonsoft.Json.JsonProperty("first", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Uri First { get; set; }
    
        [Newtonsoft.Json.JsonProperty("up", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Uri Up { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Links FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Links>(data);
        }
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.0.15.0 (NJsonSchema v9.13.22.0 (Newtonsoft.Json v12.0.0.2))")]
    public partial class SwaggerException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public SwaggerException(string message, int statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException) 
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + response.Substring(0, response.Length >= 512 ? 512 : response.Length), innerException)
        {
            StatusCode = statusCode;
            Response = response; 
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.0.15.0 (NJsonSchema v9.13.22.0 (Newtonsoft.Json v12.0.0.2))")]
    public partial class SwaggerException<TResult> : SwaggerException
    {
        public TResult Result { get; private set; }

        public SwaggerException(string message, int statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException) 
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }

    #pragma warning restore
}