using Newtonsoft.Json;

namespace TravelGateX.TestCode.Models
{
    [JsonObject]
    public class AtalayaHotel
    {
        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("city")]
        public string city { get; set; }

    }

    [JsonObject]
    public class AtalayaHotels
    {
        [JsonProperty("hotels")]
        public List<AtalayaHotel> hotels { get; set; } 

    }
}
