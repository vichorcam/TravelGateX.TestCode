using Newtonsoft.Json;

namespace TravelGateX.TestCode.Models.MealPlan
{
    [JsonObject]
    public class MealPlan
    {
        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("hotel")]
        Dictionary<string, List<RoomPrice>> hotel { get; set; }

    }

    public class RoomPrice
    {
        [JsonProperty("room")]
        public string room { get; set; }

        [JsonProperty("price")]
        public int price { get; set; }

    }

    [JsonObject]
    public class MealPlansInfo
    {
        [JsonProperty("meal_plans")]
        public List<MealPlan> mealPlans { get; set; }

    }

}
