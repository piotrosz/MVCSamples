using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjectExample1
{
    public class LinqValueCalculator : IValueCalculator
    {
        private IDiscountHelper discountHelper;

        public LinqValueCalculator(IDiscountHelper discountHelper)
        {
            this.discountHelper = discountHelper;
        }

        public decimal ValueProducts(params Product[] products)
        {
            return discountHelper.ApplyDiscount(
                products.Sum(x => x.Price));
        }
    }
}
