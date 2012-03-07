using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;

namespace NinjectExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Binding to derived type
            StandardKernel kernel = new StandardKernel();

            kernel.Bind<IValueCalculator>().To<LinqValueCalculator>();

            kernel.Bind<ShoppingCart>()
                .To<LimitShoppingCart>()
                .WithPropertyValue("ItemLimit", 200M);

            var cart = kernel.Get<ShoppingCart>();

            // Conditional binding

            //kernel.Bind<IValueCalculator>().To<LinqValueCalculator>();
            //kernel.Bind<IValueCalculator>()
            //    .To<IterativeValueCalculator>()
            //    .WhenInjectedInto<LimitShoppingCart>();

        }
    }
}
