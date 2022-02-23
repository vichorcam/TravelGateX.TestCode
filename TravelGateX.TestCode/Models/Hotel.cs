using Newtonsoft.Json;

namespace TravelGateX.TestCode.Models.Hotel
{
    [JsonObject]
    public class Hotel
    {
        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("city")]
        public string city { get; set; }

    }

    [JsonObject]
    public class HotelsInfo
    {
        [JsonProperty("hotels")]
        public List<Hotel> hotels { get; set; } 

    }
}
