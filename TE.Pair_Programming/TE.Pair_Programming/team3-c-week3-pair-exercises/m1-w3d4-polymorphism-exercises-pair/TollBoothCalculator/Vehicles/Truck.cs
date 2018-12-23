using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Vehicles
{
    class Truck : IVehicle
    {
        
        private int numberOfAxles;


        public Truck(int numberOfAxles)
        {
            this.numberOfAxles = numberOfAxles;
        }

        
        public int NumberOfAxels
        {
            get { return numberOfAxles; }
        }

        public double CalculateToll(int distance)
        {
            if (NumberOfAxels >= 8)
            {
                double toll = distance * .048;
                return toll;
            }
            else if (numberOfAxles == 6)
            {
                double toll = distance * .045;
                return toll;
            }
            else
            {
                double toll = distance * .040;
                return toll;

            }
        }
    }

}
