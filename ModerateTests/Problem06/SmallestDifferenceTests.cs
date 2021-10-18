using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moderate.Problem06;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModerateTests.Problem06
{
    [TestClass]
    public class SmallestDifferenceTests
    {
        SmallestDifference smallestDifference = new SmallestDifference();

        [TestMethod]
        [DynamicData(nameof(SmallestDifferenceTestsData.ExecuteSuccessData), typeof(SmallestDifferenceTestsData), DynamicDataSourceType.Method)]
        public void ExecuteSuccess(
            string _,
            int[] array1,
            int[] array2,
            int expectedDifference)
        {
            int difference = smallestDifference.FindSmallestDifference(array1, array2);

            difference.Should().Be(expectedDifference);
        }
    }
}
