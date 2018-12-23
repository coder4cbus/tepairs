using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostageCalculator.Classes;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeliveryDriver> deliveryThing = new List<IDeliveryDriver>();

            deliveryThing.Add(new FirstClass());
            deliveryThing.Add(new SecondClass());
            deliveryThing.Add(new ThirdClass());
            deliveryThing.Add(new FexEd());
            deliveryThing.Add(new SPU_4Day());
            deliveryThing.Add(new SPU_2Day());
            deliveryThing.Add(new SPU_nextDay());


            Console.WriteLine("Please Enter Weight of Package.");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("(P)ounds or (O)unces?");
            string weightUnits = Console.ReadLine();

          //  while ((weightUnits != "P" || weightUnits != "p") && (weightUnits != "O" || weightUnits != "o"))
            {
                if ((weightUnits == "P") || (weightUnits == "p"))
                {
                    weight = weight * 16;
                    //Console.WriteLine("Pounds to Ounces" + weight);
                }
                else if (weightUnits == "O" || weightUnits == "o")

                    weight = weight * 1;
                //else Console.WriteLine("Ounces:" weight);
                else if ((weightUnits != "P" || weightUnits != "p") && (weightUnits != "O" || weightUnits != "o"))
                {
                    Console.WriteLine("Please enter a valid weight unit");
                    //How to we send it back to asking for weight correct weight unit?
                }
            }


            Console.WriteLine("What distance will it be traveling?");
            int distance = int.Parse(Console.ReadLine());
            Console.WriteLine();

            foreach (IDeliveryDriver thing in deliveryThing)
            {
                Console.WriteLine($"{thing.GetType().Name}  {(thing.CalculateRate(distance, weight))}");
            }
        }
    }
}

