using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moderate.Problem05;

namespace ModerateTests.Problem05
{
    [TestClass]
    public class FactorialZeroTests
    {
        FactorialZeros factorialZeros = new FactorialZeros();

        [TestMethod]
        public void SuccessFindZeros()
        {
            int result = factorialZeros.FindZeros(9);

            result.Should().Be(1);
        }
    }
}
