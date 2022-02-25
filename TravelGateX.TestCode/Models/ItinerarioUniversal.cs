using Newtonsoft.Json;

namespace TravelGateX.TestCode.Models
{
    public class ItinerarioRoom
    {

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("room_type")]
        public string roomType { get; set; }

        [JsonProperty("meal_plan")]
        public string mealPlan { get; set; }

        [JsonProperty("price")]
        public int price { get; set; }

        [JsonProperty("nights")]
        public int nights { get; set; }
    }

    public class ItinerarioHotel
    {

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("city")]
        public string city { get; set; }

        [JsonProperty("rooms")]
        public List<ItinerarioRoom> rooms { get; set; } = new List<ItinerarioRoom>();
    }

    public class ItineratioUniversal
    {

        [JsonProperty("hotels")]
        public List<ItinerarioHotel> hotels { get; set; } = new List<ItinerarioHotel>();
    }
}
