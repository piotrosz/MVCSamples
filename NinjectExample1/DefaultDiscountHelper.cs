using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjectExample1
{
    public class DefaultDiscountHelper : IDiscountHelper
    {
        public decimal DiscountSize { get; set; }

        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (this.DiscountSize / 100m * totalParam));
        }
    }
}
