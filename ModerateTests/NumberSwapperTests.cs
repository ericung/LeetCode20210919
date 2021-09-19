using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moderate.Problem01;

namespace ModerateTests
{
    [TestClass]
    public class NumberSwapperTests
    {
        NumberSwapper numberSwapper = new NumberSwapper();

        [TestMethod]
        [DynamicData(nameof(NumberSwapperTestsData.SwapSuccessfullyData), typeof(NumberSwapperTestsData), DynamicDataSourceType.Method)]
        public void SwapSuccessfully(string _, int a, int b)
        {
            int oldA = a;
            int oldB = b;

            numberSwapper.Swap(ref a, ref b);

            a.Should().Be(oldB);
            b.Should().Be(oldA);
        }
    }
}
