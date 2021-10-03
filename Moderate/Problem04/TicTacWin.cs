using System;
using System.Collections.Generic;
using System.Text;

namespace Moderate.Problem04
{
    public class TicTacWin
    {
        public Boolean TicTacToe(String[,] board)
        {
            int n = board.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                // horizontal rows
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] != board[i, 0])
                    {
                        break;
                    }

                    if (j == n - 1)
                    {
                        return true;
                    }
                }

                // vertical rows
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[j, i] != board[0, i])
                    {
                        break;
                    }

                    if (j == n - 1)
                    {
                        return true;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (board[i,i] != board[0,0])
                {
                    break;
                }

                if (i == n - 1)
                {
                    return true;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (board[n - 1, 0] != board[n - 1 - i, i])
                {
                    break;
                }

                if (i == n - 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
