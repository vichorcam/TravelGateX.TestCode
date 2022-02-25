using Newtonsoft.Json;

namespace TravelGateX.TestCode.Models
{
    [JsonObject]
    public class AtalayaMealPlan
    {
        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("hotel")]
        public Dictionary<string, List<AtalayaRoomPrice>> hotel { get; set; }

    }

    public class AtalayaRoomPrice
    {
        [JsonProperty("room")]
        public string room { get; set; }

        [JsonProperty("price")]
        public int price { get; set; }

    }

    [JsonObject]
    public class AtalayaMealPlans
    {
        [JsonProperty("meal_plans")]
        public List<AtalayaMealPlan> mealPlans { get; set; }

    }

}
