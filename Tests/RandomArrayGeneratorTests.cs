using ClassLibrary;
using Xunit;

namespace Tests
{
    public class RandomArrayGeneratorTests
    {
        [Fact]
        public void TestGetRandomArray()
        {
            RandomArrayGenerator generator = new();
            int arrayLength = 10;

            var array = generator.GetRandomArray(arrayLength);

            Assert.Equal(array.Length, arrayLength);

            foreach ( var item in array)
            {
                Assert.InRange(item, 0, 10);
            }
        }
    }
}
