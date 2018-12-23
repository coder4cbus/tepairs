using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Vehicles
{
    public class Car : IVehicle
    {

        private bool hasTrailer;

        public Car(bool hasTrailer)
        {
            this.hasTrailer = hasTrailer;
        }
        //properties
        public bool HasTrailer
        {
            get { return hasTrailer; }
        }
        //method from interface
        public double CalculateToll(int distance)
        {
            double toll = distance * .020;

            if (hasTrailer == true)
            {
                toll += 1;
                return toll;
            }
            return toll;
        }
    }
}
