using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode
{
    public class GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            Stack<(StringBuilder, int)> stack = new Stack<(StringBuilder, int)>();
            HashSet<string> solutions = new HashSet<string>();
            stack.Push((new StringBuilder(), 0));

            while(stack.Any())
            {
                (StringBuilder current, int lefts) = stack.Pop();

                if (current.Length + lefts == 2*n)
                {
                    while(lefts > 0)
                    {
                        current = current.Append(')');
                        lefts--;
                    }
                    
                    if (!solutions.Contains(current.ToString()))
                    {
                        solutions.Add(current.ToString());
                    }
                }
                else if (current.Length + lefts < 2*n)
                {
                    stack.Push((new StringBuilder(current + "("), lefts + 1));
                    if (lefts > 0)
                    {
                        stack.Push((new StringBuilder(current + ")"), lefts - 1));
                    }
                }
            }

            return solutions.ToList();
        }
    }
}
