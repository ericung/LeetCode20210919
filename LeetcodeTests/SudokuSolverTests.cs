using Leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeTests
{
    [TestClass]
    public class SudokuSolverTests
    {
        [TestMethod]
        public void Success()
        {
            SudokuSolver sudokuSolver = new SudokuSolver();

            char[][] board = new char[9][]
                { 
                    new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                    new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                    new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                    new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                    new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                    new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                    new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                    new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                    new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
                };

            sudokuSolver.SolveSudoku(board);
        }
    }
}
