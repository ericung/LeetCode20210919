using BitManipulation.Problem01;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BitManipulationTests.Problem01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Insertion insertion = new Insertion();
            ListNode head = new ListNode(6, new ListNode(6, new ListNode(6, new ListNode(6))));

            ListNode newNode = insertion.RemoveElements(head, 6);
        }
    }
}
