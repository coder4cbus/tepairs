using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    class ThirdClass : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = 0.0;
            if (weight <= 2)
            {
                rate = 0.0020;
            }
            else if (weight <= 8)
            {
                rate = 0.0022;
            }
            else if (weight <= 15)
            {
                rate = 0.0024;
            }
            else if (weight <= (3 * 16))
            {
                rate = 0.0150;
            }
            else if (weight <= (8 * 16))
            {
                rate = 0.0160;
            }
            else rate = 0.0170;

            return distance * rate;
        }
    }
}