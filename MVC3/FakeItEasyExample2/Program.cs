using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FakeItEasy;

namespace FakeItEasyExample2
{
    class Program
    {
        // based on
        // http://msdn.microsoft.com/en-us/magazine/cc163904.aspx

        static void Main()
        {
            IShoppingDataAccess fakeDataAccess = A.Fake<IShoppingDataAccess>();

            Basket basket = new Basket(fakeDataAccess);
            basket.Save();

            A.CallTo(() => fakeDataAccess.GetUnitPrice(99)).Returns(120);
            A.CallTo(() => fakeDataAccess.GetProductName(A<int>.Ignored)).Returns("Always banana");

            BasketItem basketItem = new BasketItem(99, 3, fakeDataAccess);

            // Assertion
            A.CallTo(() => fakeDataAccess.GetProductName(99)).MustHaveHappened();

            Console.WriteLine(basketItem.Price);
            Console.WriteLine(basketItem.ProductName);
        }
    }
}
