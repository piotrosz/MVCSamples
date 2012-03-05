using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjectExample1
{
    public class DefaultDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (20m / 100m * totalParam));
        }
    }
}
