using System;
using System.Collections.Generic;

namespace FakeItEasyExample2
{
    public interface IShoppingDataAccess
    {
        string GetProductName(int productID);
        int GetUnitPrice(int productID);
        IEnumerable<BasketItem> LoadBasketItems(Guid basketID);
        void SaveBasketItems(Guid basketID, IEnumerable<BasketItem> basketItems);
    }
}
