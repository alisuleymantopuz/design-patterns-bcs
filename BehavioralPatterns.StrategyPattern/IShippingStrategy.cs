using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.StrategyPattern
{
    public interface IShippingStrategy
    {
        double Calculate(Order order);
    }
}
