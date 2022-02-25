using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using TravelGateX.TestCode.Models.UniversalHotel;
using TravelGateX.TestCode.Models;




using (var client = new HttpClient())
{
    //GET ATALAYA hotels information
    string urlAtalayaHotels = "http://www.mocky.io/v2/5e4a7e4f2f00005d0097d253";

    var resAtalayaHotels = client.GetAsync(urlAtalayaHotels).Result.Content.ReadAsStringAsync().Result;

    var AtalayaHotels = JsonConvert.DeserializeObject<AtalayaHotels>(resAtalayaHotels);


    //GET ATALAYA rooms information
    string urlAtalayaRooms = "https://run.mocky.io/v3/132af02e-8beb-438f-ac6e-a9902bc67036";

    var resAtalayaRooms = client.GetAsync(urlAtalayaRooms).Result.Content.ReadAsStringAsync().Result;

    var AtalayaRooms = JsonConvert.DeserializeObject<AtalayaRooms>(resAtalayaRooms);


    //GET ATALAYA meal plans information
    string urlAtalayaMealPlans = "http://www.mocky.io/v2/5e4a7e282f0000490097d252";

    var resAtalayaMealPlans = client.GetAsync(urlAtalayaMealPlans).Result.Content.ReadAsStringAsync().Result;

    var atalayaMealPlans = JsonConvert.DeserializeObject<AtalayaMealPlans>(resAtalayaMealPlans);


    //GET RESORT hotel with rooms information
    string urlResortHotelRooms = "http://www.mocky.io/v2/5e4e43272f00006c0016a52b";

    var resResortHotelRooms = client.GetAsync(urlResortHotelRooms).Result.Content.ReadAsStringAsync().Result;

    var resortHotelRooms = JsonConvert.DeserializeObject<ResortHotelRooms>(resResortHotelRooms);


    //GET RESORT meal plans information
    string urlResortMealPlans = "http://www.mocky.io/v2/5e4a7dd02f0000290097d24b";

    var resResortMealPlans = client.GetAsync(urlResortMealPlans).Result.Content.ReadAsStringAsync().Result;

    var resortMealPlans = JsonConvert.DeserializeObject<ResortMealPlans>(resResortMealPlans);


    UniversalHotels universalHotels = new UniversalHotels();
    UniversalHotel a = new UniversalHotel();


}

