using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class SecondClass : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = 0.0;
            if (weight <= 2)
            {
                rate = 0.0035;
            }
            else if (weight <= 8)
            {
                rate = 0.0040;
            }
            else if (weight <= 15)
            {
                rate = 0.0047;
            }
            else if (weight <= (3 * 16))
            {
                rate = 0.0195;
            }
            else if (weight <= (8 * 16))
            {
                rate = 0.0450;
            }
            else rate = 0.0500;

            return distance * rate;
        }
    }
}
