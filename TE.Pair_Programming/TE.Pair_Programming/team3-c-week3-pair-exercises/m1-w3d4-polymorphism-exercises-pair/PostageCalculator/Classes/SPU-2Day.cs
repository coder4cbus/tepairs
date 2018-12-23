using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    class SPU_2Day : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = ((weight/16) * 0.050) * distance;
            return rate;
        }
    }
}
