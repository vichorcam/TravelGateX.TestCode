using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using TravelGateX.TestCode.Models;
using TravelGateX.TestCode.Adapters;




using (var client = new HttpClient())
{
    //GET ATALAYA hotels information
    var resAtalayaHotels = client.GetAsync("http://www.mocky.io/v2/5e4a7e4f2f00005d0097d253").Result.Content.ReadAsStringAsync().Result;
    var atalayaHotels = JsonConvert.DeserializeObject<AtalayaHotels>(resAtalayaHotels);


    //GET ATALAYA rooms information
    var resAtalayaRooms = client.GetAsync("https://run.mocky.io/v3/132af02e-8beb-438f-ac6e-a9902bc67036").Result.Content.ReadAsStringAsync().Result;
    var atalayaRooms = JsonConvert.DeserializeObject<AtalayaRooms>(resAtalayaRooms);


    //GET ATALAYA meal plans information
    var resAtalayaMealPlans = client.GetAsync("http://www.mocky.io/v2/5e4a7e282f0000490097d252").Result.Content.ReadAsStringAsync().Result;
    var atalayaMealPlans = JsonConvert.DeserializeObject<AtalayaMealPlans>(resAtalayaMealPlans);



    //GET RESORT hotel with rooms information
    var resResortHotelRooms = client.GetAsync("http://www.mocky.io/v2/5e4e43272f00006c0016a52b").Result.Content.ReadAsStringAsync().Result;
    var resortHotelRooms = JsonConvert.DeserializeObject<ResortHotelRooms>(resResortHotelRooms);


    //GET RESORT meal plans information
    var resResortMealPlans = client.GetAsync("http://www.mocky.io/v2/5e4a7dd02f0000290097d24b").Result.Content.ReadAsStringAsync().Result;
    var resortMealPlans = JsonConvert.DeserializeObject<ResortMealPlans>(resResortMealPlans);




    UniversalHotels universalHotels = new UniversalHotels();
    universalHotels.hotels = SupplierToUniversal.AtalayaToUniversalHotels(atalayaHotels, atalayaRooms, atalayaMealPlans);
    universalHotels.hotels.AddRange(SupplierToUniversal.ResortToUniversalHotels(resortHotelRooms, resortMealPlans));
    var viajesElCaminito = JsonConvert.SerializeObject(universalHotels,Formatting.Indented);

    Console.WriteLine("Punto 1:" + System.Environment.NewLine + viajesElCaminito);

    //Console.WriteLine("Punto 2");

    //var result = universalHotels.hotels.Where(h => h.city == "Cancun" && h.rooms.mealPlan == "ad");//.Min(h=>h.rooms.price);




}

