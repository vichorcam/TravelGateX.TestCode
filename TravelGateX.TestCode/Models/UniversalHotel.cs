using Newtonsoft.Json;

namespace TravelGateX.TestCode.Models.UniversalHotel
{
    public class Rooms
    {

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("room_type")]
        public string roomType { get; set; }

        [JsonProperty("meals_plan")]
        public string mealsPlan { get; set; }

        [JsonProperty("price")]
        public int price { get; set; }
    }

    public class Hotel
    {

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("city")]
        public string city { get; set; }

        [JsonProperty("rooms")]
        public Rooms rooms { get; set; }
    }

    public class UniversalHotelsInfo
    {

        [JsonProperty("hotels")]
        public IList<Hotel> hotels { get; set; }
    }
}
