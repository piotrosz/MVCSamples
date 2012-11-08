using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTarget;
using Xunit;
using FakeItEasy;

namespace FakeItEasyTest1
{
    public class BasketFacts
    {
        public class SaveMethod
        {
            [Fact]
            public void calculates_correct_subtotal()
            {
                // Arrange
                var dataAccess = A.Fake<IShoppingDataAccess>();
                var item1 = new BasketItem(12, 34, dataAccess);
                var item2 = new BasketItem(1, 2, dataAccess);

                var target = new Basket(dataAccess);

                target.AddItem(item1);
                target.AddItem(item2);
                
                // Act
                var result = target.CalculateSubTotal();
                
                // Assert
                Assert.Equal(12 * 34 + 1 * 2, result);   
            }

            [Fact]
            public void saves_calls_data_access_save_with_correct_params()
            {
                // Arrange
                var dataAccess = A.Fake<IShoppingDataAccess>();
                var item = new BasketItem(12, 34, dataAccess);
                var target = new Basket(dataAccess);

                target.AddItem(item);

                // Act
                target.Save();

                // Assert
                A.CallTo(() => dataAccess.SaveBasketItems(A<Guid>.Ignored, A<IEnumerable<BasketItem>>.That.Contains(item))).MustHaveHappened(Repeated.Exactly.Once);
            }
        }
    }
}
