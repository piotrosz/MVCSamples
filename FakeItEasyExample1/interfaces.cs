using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakeItEasyExample1
{
    public interface ICandyShop
    {
        ICandy GetTopSellingCandy();
    }

    public interface ICandy
    {
        string Name { get; set; }
        decimal Price { get; set; }
    }

    public interface IExceptionShop
    {
        ICandy GetTopSellingCandy();
        string Name { get; set;}
    }

    public interface IComplicated
    {
        IEnumerable<ICandy> Search(string name, decimal price);

        string M1();
        string M2();
        string M3();
    }
}
