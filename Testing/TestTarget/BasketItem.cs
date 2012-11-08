using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTarget
{
    public class BasketItem
    {
        private decimal unitPrice;
        private int productID;
        private int quantity;
        private IShoppingDataAccess dataAccess;
        private string productName;

        public BasketItem(int productID, int quantity, IShoppingDataAccess dataAccess)
        {
            Initialize(productID, quantity, dataAccess);
        }

        private void Initialize(int productID, int quantity, IShoppingDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
            this.ProductID = productID;
            this.Quantity = quantity;
        }

        public decimal UnitPrice { get { return unitPrice; } }

        public int ProductID
        {
            get { return productID; }
            set
            {
                productID = value;
                unitPrice = dataAccess.GetUnitPrice(productID);
                productName = dataAccess.GetProductName(productID);
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string ProductName { get { return productName; } }
        public decimal Price { get { return unitPrice * quantity; } }
    }
}
