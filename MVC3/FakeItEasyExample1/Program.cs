using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FakeItEasy;

namespace FakeItEasyExample1
{
    class Program
    {
        static void Main()
        {
            // --- Simple fake
            ICandyShop fakeShop = A.Fake<ICandyShop>();
            ICandy fakeCandy = A.Fake<ICandy>();

            A.CallTo(() => fakeCandy.Name).Returns("Fake candy");
            A.CallTo(() => fakeCandy.Price).Returns(10);

            Console.WriteLine(fakeCandy.Name);
            Console.WriteLine(fakeCandy.Price);

            A.CallTo(() => fakeShop.GetTopSellingCandy()).Returns(fakeCandy);

            ICandy topCandy = fakeShop.GetTopSellingCandy();
            Console.WriteLine("{0} {1}", topCandy.Name, topCandy.Price);
            // ---

            // --- Throws, any method
            IExceptionShop fake2 = A.Fake<IExceptionShop>();
            A.CallTo(fake2).Throws(new ArgumentException());

            try
            {
                string name = fake2.Name;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            // ---

            // --- WithReturnType
            IComplicated fake3 = A.Fake<IComplicated>();
            A.CallTo(fake3).WithReturnType<string>().Returns("ABC");

            Console.WriteLine(fake3.M1());
            Console.WriteLine(fake3.M2());
            Console.WriteLine(fake3.M3());
        }
    }
}
