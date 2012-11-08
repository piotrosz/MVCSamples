using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTarget;
using Xunit;

namespace FakeItEasyTest1
{
    public class DeveloperFacts
    {
        public class BuyTastiestCandyMethod
        {
            [Fact]
            public void calls_get_top_selling_candy()
            {
                // Arrange
                var candy = A.Fake<ICandy>();
                var shop = A.Fake<ICandyShop>();

                A.CallTo(() => shop.GetTopSellingCandy()).Returns(candy);

                var target = new Developer(shop);

                // Act
                var result = target.BuyTastiestCandy();

                // Assert
                A.CallTo(() => shop.GetTopSellingCandy()).MustHaveHappened(Repeated.Exactly.Once);
            }

            [Fact]
            public void throws_exception_for_too_expensive_candy()
            {
                // Arrange
                var candy = A.Fake<ICandy>();
                var shop = A.Fake<ICandyShop>();

                A.CallTo(() => candy.Price).Returns(10000);
                A.CallTo(() => shop.GetTopSellingCandy()).Returns(candy);

                var target = new Developer(shop);

                // Act
                var result = Assert.Throws<Exception>(() => target.BuyTastiestCandy());
                
                // Assert
                Assert.Equal(result.Message, "Too expensive");
            }
        }
    }
}
