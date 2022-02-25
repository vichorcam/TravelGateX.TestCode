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



    //Adaptamos los productos de los proveedores a el porducto universal
    UniversalHotels universalHotels = new UniversalHotels();
    universalHotels.hotels = SupplierToUniversal.AtalayaToUniversalHotels(atalayaHotels, atalayaRooms, atalayaMealPlans);
    universalHotels.hotels.AddRange(SupplierToUniversal.ResortToUniversalHotels(resortHotelRooms, resortMealPlans));
    var viajesElCaminito = JsonConvert.SerializeObject(universalHotels,Formatting.Indented);

    Console.WriteLine("Punto 1:" + System.Environment.NewLine + viajesElCaminito);

    //Console.WriteLine("Punto 2");


    //Punto 2
    int presupuesto_inicial = 700;

    //Teniendo en cuenta que nuestro cliente quiere la mejor opción en malaga y que en Cancun solo desayunará en el hotel,
    //tomaremos la habitación más barata de Cancun con alojamiento y desayuno.
    UniversalHotel cancunHotel = universalHotels.hotels.Single(h => h.city == "Cancun");
    UniversalRoom cancunRooms = cancunHotel.rooms.Where(r => r.mealPlan == "ad").ToList().OrderBy(r => r.price).FirstOrDefault();
    int precio_cancun = 2 * (5 * cancunRooms.price);
    int presupuesto_malaga = presupuesto_inicial - precio_cancun;


    //El cliente indica que quiere la mejor opción disponible en Malaga.
    //Yo he supuesto que la mejor opción es la más cara, pero no me queda claro si esto sería así.
    UniversalHotel malagaHotel = universalHotels.hotels.Single(h => h.city == "Malaga");
    UniversalRoom malagaRooms = malagaHotel.rooms.Where(r => (2*r.price*3) <= presupuesto_malaga).ToList().OrderByDescending(r => r.price).FirstOrDefault(); 


    ItineratioUniversal itUniversal =  new ItineratioUniversal();
    ItinerarioHotel ithCancun = new ItinerarioHotel()
    {
        code = cancunHotel.code,
        name = cancunHotel.name,
        city = cancunHotel.city
    };
    ItinerarioRoom itrCancun = new ItinerarioRoom() 
    {
        name = cancunRooms.name,
        roomType = cancunRooms.roomType,
        mealPlan = cancunRooms.mealPlan,
        price = 5*cancunRooms.price*2,
        nights = 5
    };
    ithCancun.rooms.Add(itrCancun);


    ItinerarioHotel ithMalaga = new ItinerarioHotel()
    {
        code = malagaHotel.code,
        name = malagaHotel.name,
        city = malagaHotel.city
    };
    ItinerarioRoom itrMalaga = new ItinerarioRoom()
    {
        name = malagaRooms.name,
        roomType = malagaRooms.roomType,
        mealPlan = malagaRooms.mealPlan,
        price = 3 * malagaRooms.price * 2,
        nights = 3
    };
    ithMalaga.rooms.Add(itrMalaga);


    itUniversal.hotels.Add(ithCancun);
    itUniversal.hotels.Add(ithMalaga);


    var itinerarioCliente = JsonConvert.SerializeObject(itUniversal, Formatting.Indented);
    Console.WriteLine ( System.Environment.NewLine + "Punto 2" + System.Environment.NewLine + itinerarioCliente);

}

