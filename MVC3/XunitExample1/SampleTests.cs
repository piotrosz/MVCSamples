using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xunit;

namespace XUnitExample1
{
    public class MathTest
    {
        [Fact]
        public void i_can_make_simple_assertions()
        {
            Assert.Contains<int>(2, new List<int>() { 1, 2, 3 });
            Assert.Contains("kot", "Ala ma kota", StringComparison.InvariantCultureIgnoreCase);

            Assert.DoesNotContain<int>(2, new List<int>() { 1, 1, 1 });
            Assert.DoesNotContain("pies", "Ala ma kota");

            Assert.Throws<InvalidOperationException>(
                delegate
                {
                    throw new InvalidOperationException();
                });

            Assert.DoesNotThrow(
                delegate
                {
                    
                });

            Assert.Empty(new List<int>());

            Assert.Equal<int>(4, 2 + 2);
            Assert.NotEqual<int>(4, 2 + 3);

            Assert.False(1 == 2, "Message");
            Assert.True(1 == 1, "Message");

            Assert.InRange<int>(2, 0, 10);
            Assert.NotInRange<int>(100, 0, 10);

            Assert.IsAssignableFrom(typeof(int), 2);
            Assert.IsAssignableFrom<int>(2);

            Assert.IsNotType(typeof(int), "A");
            Assert.IsNotType<int>("3");
            Assert.IsType(typeof(int), 2);
            Assert.IsType<int>(2);

            Assert.NotNull(1);
            Assert.Null(null);

            object o = new object();
            object o2 = o;
            Assert.Same(o, o2);
            Assert.NotSame("123", "1232");

            Assert.Single(new List<string>() { "" });
            Assert.Single(new List<string>() { "A", "B" }, x => x == "A");
            Assert.Single(new List<string>() { "A", "b", "c" }, "c");
        }
    }
}