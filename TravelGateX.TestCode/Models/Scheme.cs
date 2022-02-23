using Newtonsoft.Json;

namespace TravelGateX.TestCode.Models.Scheme
{
    public class Scheme
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

    public class SchemesInfo
    {

        [JsonProperty("regimenes")]
        public IList<Scheme> schemes { get; set; }
    }
}
