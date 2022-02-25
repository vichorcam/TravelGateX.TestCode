using Newtonsoft.Json;

namespace TravelGateX.TestCode.Models
{
    [JsonObject]
    public class RoomType
    {
        [JsonProperty("hotels")]
        public List<string> hotels { get; set; }

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

    }

    [JsonObject]
    public class AtalayaRooms
    {
        [JsonProperty("rooms_type")]
        public List<RoomType> roomsType { get; set; }

    }
}
