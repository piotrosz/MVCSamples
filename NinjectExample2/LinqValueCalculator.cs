using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjectExample2
{
    public class LinqValueCalculator : IValueCalculator
    {
        public decimal ValueProducts(params Product[] products)
        {
            return products.Sum(x => x.Price);
        }
    }
}
