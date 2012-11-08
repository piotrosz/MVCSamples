using System;

namespace TestTarget
{
    public class Developer
    {
        private ICandyShop candyShop;

        public Developer(ICandyShop candyShop)
        {
            this.candyShop = candyShop;
        }

        public ICandy BuyTastiestCandy()
        {
            var candy = candyShop.GetTopSellingCandy();

            if (candy.Price > 1000)
            {
                throw new Exception("Too expensive");
            }

            return candy;
        }
    }
}
