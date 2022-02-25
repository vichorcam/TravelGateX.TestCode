using Newtonsoft.Json;

namespace TravelGateX.TestCode.Models
{
    public class Room
    {

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class Hotel
    {

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("location")]
        public string location { get; set; }

        [JsonProperty("rooms")]
        public IList<Room> rooms { get; set; }
    }

    public class ResortHotelRooms
    {

        [JsonProperty("hotels")]
        public IList<Hotel> hotels { get; set; }
    }
}
