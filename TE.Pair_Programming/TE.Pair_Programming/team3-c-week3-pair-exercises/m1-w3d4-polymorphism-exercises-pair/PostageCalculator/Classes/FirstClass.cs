using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class FirstClass : IDeliveryDriver
    {

        public double CalculateRate(int distance, double weight)
        {
            double rate = 0.0;
            if (weight <= 2)
            {
                rate = 0.035;
            }
            else if (weight <= 8)
            {
                rate = 0.040;
            }
            else if (weight <= 15)
            {
                rate = 0.047;
            }
            else if (weight <= (3 * 16))
            {
                rate = 0.195;
            }
            else if (weight <= (8 * 16))
            {
                rate = 0.450;
            }
            else rate = 0.50;

            return distance * rate;
        }

    }
}
