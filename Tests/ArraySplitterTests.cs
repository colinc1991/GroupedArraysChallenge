using ClassLibrary;
using Xunit;

namespace Tests
{
    public class ArraySplitterTests
    {
        private ArraySplitter _splitter;
        private int[] _testArray = new int[6];

        public ArraySplitterTests()
        {
            _splitter = new();
            _testArray = new int[] { 1, 2, 3, 4, 5, 6 };
        }

        [Fact]
        public void TestGetSplitArrayCanBeDividedEvenly()
        {
            var evenlyDividedResult = _splitter.GetSplitArray(_testArray, 2);
            Assert.Equal(2, evenlyDividedResult.Length);
            foreach (int[] i in evenlyDividedResult)
            {
                Assert.Equal(3, i.Length);
            }
        }

        [Fact]
        public void TestGetSplitArrayCanBeDividedWithRemainder()
        {
            var remainderResult = _splitter.GetSplitArray(_testArray, 5);
            Assert.Equal(5, remainderResult.Length);

            for (int i = 0; i < remainderResult.Length; i++)
            {
                if (i == 0)
                {
                    Assert.Equal(2, remainderResult[i].Length);
                }
                else
                {
                    Assert.Single(remainderResult[i]);
                }
            }
        }
    }
}
