using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public interface IDeliveryDriver 
    {

        //methods
        double CalculateRate(int distance, double weight);
    }
}
