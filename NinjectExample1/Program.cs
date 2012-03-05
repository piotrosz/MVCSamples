using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Ninject;

namespace NinjectExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardKernel kernel = new StandardKernel();
            kernel.Bind<IValueCalculator>().To<LinqValueCalculator>();


            IValueCalculator valueCalc = kernel.Get<IValueCalculator>();
            ShoppingCart cart = new ShoppingCart(valueCalc);
            Console.WriteLine("Total is: {0}", cart.CalculateStockValue());
        }
    }
}
