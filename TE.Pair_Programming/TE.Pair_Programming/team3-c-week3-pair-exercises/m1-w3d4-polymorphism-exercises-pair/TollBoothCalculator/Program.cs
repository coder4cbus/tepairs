using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothCalculator.Vehicles;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> tollRoad = new List<IVehicle>();

            tollRoad.Add(new Car(false));
            tollRoad.Add(new Car(true));
            tollRoad.Add(new Truck(4));
            tollRoad.Add(new Truck(6));
            tollRoad.Add(new Truck(8));
            tollRoad.Add(new Tank());

            Random random = new Random();
            int totalDistance = 0;
            double totalRevenue = 0;

            foreach(IVehicle vehicle in tollRoad)
            {
                int distance = random.Next(10, 241);
                Console.WriteLine($"Vehicle Type: {vehicle.GetType().Name}, Distance Traveled: {distance}, and Toll Owed: {vehicle.CalculateToll(distance)}");
                Console.WriteLine();
                Console.WriteLine("===========================");

                totalDistance += distance;
                totalRevenue += vehicle.CalculateToll(totalDistance);
                //Sum distance travel all vehicles 
                
            }
            Console.WriteLine();
            Console.WriteLine("Total Distance: " + totalDistance + " miles");
            Console.WriteLine("===========================");
            Console.WriteLine("Total Revenue: $" + totalRevenue);
            Console.WriteLine();
        }
    }
}
