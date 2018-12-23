using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Vehicles
{
    public class Tank : IVehicle
    {
        public double CalculateToll(int distance)
        {
            double toll = distance * 0;
            return toll;
        }
    }
}
