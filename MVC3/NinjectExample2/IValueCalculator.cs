using System;

namespace NinjectExample2
{
    public interface IValueCalculator
    {
        decimal ValueProducts(params Product[] products);
    }
}
