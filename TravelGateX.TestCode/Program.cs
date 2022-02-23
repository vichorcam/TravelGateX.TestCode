using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using TravelGateX.TestCode.Models.Hotel;
using TravelGateX.TestCode.Models.MealPlan;
using TravelGateX.TestCode.Models.RoomsType;
using TravelGateX.TestCode.Models.HotelRooms;
using TravelGateX.TestCode.Models.Scheme;

using (var client = new HttpClient())
{
    //GET Supplier hotel information
    string urlHotels = "http://www.mocky.io/v2/5e4a7e4f2f00005d0097d253";

    var resHotels = client.GetAsync(urlHotels).Result.Content.ReadAsStringAsync().Result;

    var hotelsInfo = JsonConvert.DeserializeObject<HotelsInfo>(resHotels);


    //GET Supplier room information
    string urlRoomsType = "https://run.mocky.io/v3/132af02e-8beb-438f-ac6e-a9902bc67036";

    var resRoomsType = client.GetAsync(urlRoomsType).Result.Content.ReadAsStringAsync().Result;

    var roomsTypeInfo = JsonConvert.DeserializeObject<RoomsTypeInfo>(resRoomsType);


    //GET Supplier meal plans information
    string urlMealPlans = "http://www.mocky.io/v2/5e4a7e282f0000490097d252";

    var resMealPlans = client.GetAsync(urlMealPlans).Result.Content.ReadAsStringAsync().Result;

    var mealPlansInfo = JsonConvert.DeserializeObject<MealPlansInfo>(resMealPlans);


    //GET Supplier hotel with rooms information
    string urlHotelRooms = "http://www.mocky.io/v2/5e4e43272f00006c0016a52b";

    var resHotelRooms = client.GetAsync(urlHotelRooms).Result.Content.ReadAsStringAsync().Result;

    var hotelRoomsInfo = JsonConvert.DeserializeObject<HotelRoomsInfo>(resHotelRooms);


    //GET Available schemes information
    string urlSchemes = "http://www.mocky.io/v2/5e4a7dd02f0000290097d24b";

    var resSchemes = client.GetAsync(urlSchemes).Result.Content.ReadAsStringAsync().Result;

    var schemesInfo = JsonConvert.DeserializeObject<SchemesInfo>(resSchemes);
}

