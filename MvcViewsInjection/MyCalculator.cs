using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcViewsInjection
{
    public class MyCalculator : ICalculator
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}