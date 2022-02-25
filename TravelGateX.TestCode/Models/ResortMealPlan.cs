using Newtonsoft.Json;

namespace TravelGateX.TestCode.Models
{
    public class ResortMealPlan
    {

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("hotel")]
        public string hotel { get; set; }

        [JsonProperty("room_type")]
        public string roomType { get; set; }

        [JsonProperty("price")]
        public int price { get; set; }
    }

    public class ResortMealPlans
    {

        [JsonProperty("regimenes")]
        public IList<ResortMealPlan> mealPlans { get; set; }
    }
}
