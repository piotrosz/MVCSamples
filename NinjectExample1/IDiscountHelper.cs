using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjectExample1
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalParam);
    }
}
