using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.StrategyPattern
{
    public class SchenkerShippingStrategy : IShippingStrategy
    {

        public double Calculate(Order order)
        {
            return 3;
        }
    }
}
