using Newtonsoft.Json;

namespace TravelGateX.TestCode.Models
{
    public class UniversalRoom
    {

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("room_type")]
        public string roomType { get; set; }

        [JsonProperty("meal_plan")]
        public string mealPlan { get; set; }

        [JsonProperty("price")]
        public int price { get; set; }
    }

    public class UniversalHotel
    {

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("city")]
        public string city { get; set; }

        [JsonProperty("rooms")]
        public List<UniversalRoom> rooms { get; set; } = new List<UniversalRoom>();
    }

    public class UniversalHotels
    {

        [JsonProperty("hotels")]
        public List<UniversalHotel> hotels { get; set; } = new List<UniversalHotel>();
    }
}
