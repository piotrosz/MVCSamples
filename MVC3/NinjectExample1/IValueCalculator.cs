using System;

namespace NinjectExample1
{
    public interface IValueCalculator
    {
        decimal ValueProducts(params Product[] products);
    }
}
