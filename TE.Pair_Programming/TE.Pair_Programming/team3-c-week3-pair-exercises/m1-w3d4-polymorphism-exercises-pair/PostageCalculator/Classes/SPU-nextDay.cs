using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    class SPU_nextDay : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = ((weight/16) * 0.075) * distance;
            return rate;
        }
    }
}
