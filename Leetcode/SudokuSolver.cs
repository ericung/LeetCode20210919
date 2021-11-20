using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class SudokuSolver
    {
        public static char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public void SolveSudoku(char[][] board)
        {
            (HashSet<char>[] rowHash, HashSet<char>[] columnHash, HashSet<char>[][] boxHash)
                = InitializeHash(board.Length);
            PopulateHash(board, rowHash, columnHash, boxHash);
            Solve(board, rowHash, columnHash, boxHash);
        }

        private int Solve(char[][] board,
            HashSet<char>[] rowHash, HashSet<char>[] columnHash, HashSet<char>[][] boxHash)
        {
            if (PlacedAll(rowHash, columnHash, boxHash))
            {
                Console.WriteLine("placed all");
                return 1;
            }

            for (int row = 0; row < board.Length; row++)
            {
                for (int column = 0; column < board[row].Length; column++)
                {
                    if (board[row][column] == '.')
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (IsValid(numbers[i], row, column, rowHash, columnHash, boxHash))
                            {
                                PlaceDigit(board, numbers[i], row, column, rowHash, columnHash, boxHash);
                                if (Solve(board, rowHash, columnHash, boxHash) == 1)
                                {
                                    return 1;
                                }
                                else
                                {
                                    RemoveDigit(board, row, column, rowHash, columnHash, boxHash);
                                }
                            }
                        }

                        return -1;
                    }
                }
            }

            return 1;
        }

        private bool PlacedAll(HashSet<char>[] rowHash, HashSet<char>[] columnHash, HashSet<char>[][] boxHash)
        {
            for (int i = 0; i < 9; i++)
            {
                if (rowHash[i].Count < 9)
                {
                    return false;
                }

                if (columnHash[i].Count < 9)
                {
                    return false;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (boxHash[i][j].Count < 9)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        private void PlaceDigit(char[][] board, char digit, int row, int column,
            HashSet<char>[] rowHash, HashSet<char>[] columnHash, HashSet<char>[][] boxHash)
        {
            board[row][column] = digit;
            rowHash[row].Add(digit);
            columnHash[column].Add(digit);
            boxHash[row / 3][column / 3].Add(digit);
        }

        private void RemoveDigit(char[][] board, int row, int column,
            HashSet<char>[] rowHash, HashSet<char>[] columnHash, HashSet<char>[][] boxHash)
        {
            char digit = board[row][column];
            board[row][column] = '.';
            rowHash[row].Remove(digit);
            columnHash[column].Remove(digit);
            boxHash[row / 3][column / 3].Remove(digit);
        }

        private bool IsValid(char potential, int row, int column, HashSet<char>[] rowHash,
            HashSet<char>[] columnHash, HashSet<char>[][] boxHash)
        {
            if ((!rowHash[row].Contains(potential)) && (!columnHash[column].Contains(potential))
               && (!boxHash[row / 3][column / 3].Contains(potential)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private (HashSet<char>[], HashSet<char>[], HashSet<char>[][]) InitializeHash(int size)
        {
            HashSet<char>[] rowHash = new HashSet<char>[size];
            HashSet<char>[] columnHash = new HashSet<char>[size];
            HashSet<char>[][] boxHash = new HashSet<char>[size / 3][];

            for (int i = 0; i < size; i++)
            {
                rowHash[i] = new HashSet<char>();
                columnHash[i] = new HashSet<char>();
            }

            for (int i = 0; i < size / 3; i++)
            {
                boxHash[i] = new HashSet<char>[size / 3];

                for (int j = 0; j < size / 3; j++)
                {
                    boxHash[i][j] = new HashSet<char>();
                }
            }

            return (rowHash, columnHash, boxHash);
        }

        private void PopulateHash(char[][] board, HashSet<char>[] rowHash,
            HashSet<char>[] columnHash, HashSet<char>[][] boxHash)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    char cell = board[i][j];
                    if (cell != '.')
                    {
                        rowHash[i].Add(cell);
                        columnHash[j].Add(cell);
                        boxHash[i / 3][j / 3].Add(cell);
                    }
                }
            }
        }
    }
}
