using Xunit;

namespace MyLibrary.Test
{
    public class DummyCalculatorTest
    {
        [Fact]
        public void SimpleTest()
        {
            var result = DummyCalculator.Add(10, 15);

            Assert.Equal(25, result);
        }
    }
}
