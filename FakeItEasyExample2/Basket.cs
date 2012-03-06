using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakeItEasyExample2
{
    // BLL
    public class Basket
    {
        private List<BasketItem> basketItems;
        private Guid basketID;
        private IShoppingDataAccess dataAccess;

        public Basket(IShoppingDataAccess dataAccess)
        {
            Initialize(dataAccess);
        }

        public void AddItem(BasketItem item)
        {
            basketItems.Add(item);
        }

        public void Save()
        {
            dataAccess.SaveBasketItems(basketID, basketItems);
        }

        public decimal CalculateSubTotal()
        {
            return basketItems.Sum(x => x.Price);
        }

        private void Initialize(IShoppingDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
            this.basketItems = new List<BasketItem>();
            this.basketID = Guid.NewGuid();
        }
    }
}
