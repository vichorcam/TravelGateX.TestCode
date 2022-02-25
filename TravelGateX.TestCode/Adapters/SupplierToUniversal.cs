using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelGateX.TestCode.Models;

namespace TravelGateX.TestCode.Adapters
{
    public class SupplierToUniversal
    {

        public static List<UniversalHotel> AtalayaToUniversalHotels(AtalayaHotels atHotels, AtalayaRooms atRooms, AtalayaMealPlans atMealPlans) 
        {
            List<UniversalHotel> universalHotels = new List<UniversalHotel>();

            //Recorremos los mealPlans ya que de aqui obtendremos la cantidad de habitaciones diferente que tenemos que crear para cada hotel.
            foreach (AtalayaMealPlan atMealPlan in atMealPlans.mealPlans) 
            { 
                foreach (string hotel_code in atMealPlan.hotel.Keys) 
                {
                    UniversalHotel uHotel = universalHotels.SingleOrDefault(h => h.code == hotel_code);
                    AtalayaHotel atHotel = atHotels.hotels.SingleOrDefault(h => h.code == hotel_code);

                    //Si el hotel de esta habitación aun no lo hemos reistrado, lo creamos
                    if (uHotel == null)
                    {
                        uHotel = new UniversalHotel()
                        {
                            code = atHotel.code,
                            name = atHotel.name,
                            city = atHotel.city
                        };
                        universalHotels.Add(uHotel);
                    }

                    foreach (AtalayaRoomPrice atRoomPrice in atMealPlan.hotel[hotel_code])
                    {
                        
                        AtalayaRoom atRoom = atRooms.roomsType.SingleOrDefault(r => r.code == atRoomPrice.room);

                        //creamos la habitación con su respectivo mealPlan
                        UniversalRoom uRoom = new UniversalRoom()
                        {
                            name = atRoom.name,
                            roomType = atRoom.code,
                            mealPlan = atMealPlan.code,
                            price = atRoomPrice.price
                        };
                        //añadimos la nueva habitación
                        uHotel.rooms.Add(uRoom);

                        
                    }

                }
            }

            return universalHotels;
        }





        public static List<UniversalHotel> ResortToUniversalHotels(ResortHotelRooms rsHotels, ResortMealPlans rsMealPlans)
        {
            List<UniversalHotel> universalHotels = new List<UniversalHotel>();


            //Recorremos los mealPlans ya que de aqui obtendremos la cantidad de habitaciones diferente que tenemos que crear para cada hotel.
            foreach (ResortMealPlan rsMealPlan in rsMealPlans.mealPlans)
            {
                UniversalHotel uHotel = universalHotels.SingleOrDefault(h => h.code == rsMealPlan.hotel);
                ResortHotel rsHotel = rsHotels.hotels.SingleOrDefault(h => h.code == rsMealPlan.hotel);
                ResortRoom rsRoom = rsHotel.rooms.SingleOrDefault(r => r.code == rsMealPlan.roomType);

                //creamos la habitación con su respectivo mealPlan
                UniversalRoom uRoom = new UniversalRoom()
                {
                    name = rsRoom.name,
                    roomType = rsMealPlan.roomType,
                    mealPlan = rsMealPlan.code,
                    price = rsMealPlan.price
                };

                //Si el hotel de esta habitación aun no lo hemos reistrado, lo creamos y le añadimos nueva habitación
                if (uHotel == null)
                {
                    UniversalHotel hotel = new UniversalHotel()
                    {
                        code = rsHotel.code,
                        name = rsHotel.name,
                        city = rsHotel.location
                    };
                    hotel.rooms.Add(uRoom);
                    universalHotels.Add(hotel);
                }
                else 
                {
                    //Si el hotel ya existe, simplemente le añadimos la nueva habitación
                    uHotel.rooms.Add(uRoom);

                }
            }

            return universalHotels;
        }
    }
}
