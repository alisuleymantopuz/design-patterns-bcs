using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ObserverPattern2
{
    public static class DecimalHelpers
    {
        public static decimal ComputeDiscountedPrice(this decimal originalPrice, decimal percentDiscount)
        {
            if (originalPrice < 0m) throw new ArgumentOutOfRangeException("originalPrice", "a price can't be negative!");
            if (percentDiscount < 0m) throw new ArgumentOutOfRangeException("percentDiscount", "a discount can't be negative!");
            if (percentDiscount > 100m) throw new ArgumentOutOfRangeException("percentDiscount", "a discount can't exceed 100%");

            decimal markdown = Math.Round(originalPrice * (percentDiscount / 100m), 2, MidpointRounding.ToEven);
            decimal discountedPrice = originalPrice - markdown;

            return discountedPrice;
        }
    }
}
