using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjectExample2
{
    public class LimitShoppingCart : ShoppingCart
    {
        public LimitShoppingCart(IValueCalculator calcParam)
            : base(calcParam)
        {
            // nothing to do here
        }

        public override decimal CalculateStockValue()
        {
            // filter out any items that are over the limit
            var filteredProducts = products
                .Where(e => e.Price < ItemLimit);

            // perform the calculation
            return calculator.ValueProducts(filteredProducts.ToArray());
        }

        public decimal ItemLimit { get; set; }
    }
}
