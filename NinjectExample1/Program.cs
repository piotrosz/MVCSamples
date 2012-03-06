using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Ninject;

namespace NinjectExample1
{
    // From Apress Pro ASP.NET MVC 3 Framework book

    class Program
    {
        static void Main()
        {
            StandardKernel kernel = new StandardKernel();

            kernel.Bind<IValueCalculator>().To<LinqValueCalculator>();

            // Property

            //kernel.Bind<IDiscountHelper>().To<DefaultDiscountHelper>().WithPropertyValue("DiscountSize", 50m);

            // Constructor argument

            kernel.Bind<IDiscountHelper>().To<DefaultDiscountHelper>().WithConstructorArgument("discountRate", 50M);


            IValueCalculator valueCalc = kernel.Get<IValueCalculator>();
            
            ShoppingCart cart = new ShoppingCart(valueCalc);
            
            Console.WriteLine("Total is: {0}", cart.CalculateStockValue());


            // Self-binding

            // this:

            IValueCalculator calc2 = kernel.Get<IValueCalculator>();
            ShoppingCart cart2 = new ShoppingCart(calc2);

            // is equivalent to:

            ShoppingCart cart3 = kernel.Get<ShoppingCart>();

            //kernel.Bind<ShoppingCart>().ToSelf().WithParameter("<parameterName>", <paramvalue>);
        }
    }
}
