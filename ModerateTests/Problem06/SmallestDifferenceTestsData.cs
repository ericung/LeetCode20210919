using System.Collections.Generic;

namespace ModerateTests.Problem06
{
    public class SmallestDifferenceTestsData
    {
        public static IEnumerable<object[]> ExecuteSuccessData()
        {
            yield return new object[]
            {
                "Same sized array",
                new int[] { 1, 3, 15, 11, 2 },
                new int[] { 23, 127, 235, 19, 8 },
                3
            };

            yield return new object[]
            {
                "Array1 larger than array2",
                new int[] { 1, 17, 20, 25, 16},
                new int[] { 5, 60},
                4
            };

            yield return new object[]
            {
                "Array2 larger than array1",
                new int[] { 17, 40 },
                new int[] { 1, 2, 45, 60, 70}, 
                5
            };
        }
    }
}
