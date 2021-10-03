using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moderate.Problem04;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModerateTests.Problem04
{
    [TestClass]
    public class TicTacWinTests
    {
        TicTacWin ticTacWin = new TicTacWin();

        [TestMethod]
        public void FalseResult()
        {
            Boolean result = ticTacWin.TicTacToe(new string[,] { { "O", "X", "O" }, { "X", "O", "X" }, { "X", "O", "X" } });

            result.Should().Be(false);
        }

        [TestMethod]
        public void Success()
        {
            Boolean result = ticTacWin.TicTacToe(new string[,] { { "X", "X", "O" }, { "X", "X", "X" }, { "O", "O", "X" } });

            result.Should().Be(true);
        }
    }
}
