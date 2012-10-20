using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjectExample1
{
    // Property

    //public class DefaultDiscountHelper : IDiscountHelper
    //{
    //    public decimal DiscountSize { get; set; }

    //    public decimal ApplyDiscount(decimal totalParam)
    //    {
    //        return (totalParam - (this.DiscountSize / 100m * totalParam));
    //    }
    //}


    // Constructor parameter

    public class DefaultDiscountHelper : IDiscountHelper
    {
        private decimal discountRate;

        public DefaultDiscountHelper(decimal discountRate)
        {
            this.discountRate = discountRate;
        }
        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (discountRate / 100m * totalParam));
        }
    }
}
