using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculator.Domain
{
    public static class Discount
    {
        public static decimal ApplyYearDiscount(this decimal oryginalPrice, int timeOfHavingAccountInYears)
        {
            if (timeOfHavingAccountInYears < 0)
            {
                throw new ArgumentException("timeOfHavingAccountInYears has to be greater than 0");
            }

            decimal yearsDiscount = (timeOfHavingAccountInYears > 5) ? (decimal)0.8 : 1;
            return yearsDiscount * oryginalPrice;
        }

    }
}
