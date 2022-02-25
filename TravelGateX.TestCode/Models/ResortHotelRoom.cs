using Newtonsoft.Json;

namespace TravelGateX.TestCode.Models
{
    public class ResortRoom
    {

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class ResortHotel
    {

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("location")]
        public string location { get; set; }

        [JsonProperty("rooms")]
        public List<ResortRoom> rooms { get; set; }
    }

    public class ResortHotelRooms
    {

        [JsonProperty("hotels")]
        public IList<ResortHotel> hotels { get; set; }
    }
}
