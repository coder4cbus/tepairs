using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class SPU_4Day : IDeliveryDriver
    {
        //constructor used

        //methods
        public double CalculateRate(int distance, double weight)
        {
            double rate = ((weight/16) * 0.0050) * distance;
            return rate;
        }
    }
}
