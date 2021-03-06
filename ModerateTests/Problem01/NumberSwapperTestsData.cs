using System.Collections.Generic;

namespace ModerateTests.Problem01
{
    public class NumberSwapperTestsData
    {
        public static IEnumerable<object[]> SwapSuccessfullyData()
        {
            yield return new object[]
            {
                "Two positive numbers",
                5,
                4
            };

            yield return new object[]
            {
                "a is negative, b is positive.",
                -5,
                4
            };

            yield return new object[]
            {
                "a is positive, b is negative.",
                5,
                -4
            };

            yield return new object[]
            {
                "a is negative, b is negative",
                -5,
                -4
            };
        }
    }
}
