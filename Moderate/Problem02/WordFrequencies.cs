using System;
using System.Collections.Generic;
using System.Text;

namespace Moderate.Problem02
{
    public class WordFrequencies
    {
        private Dictionary<string, int> _frequency = new Dictionary<string, int>();

        public void InitializeBook(string book)
        {
            foreach(string word in book.Split(' '))
            {
                if (_frequency.ContainsKey(word))
                {
                    _frequency[word]++;
                }
                else
                {
                    _frequency[word] = 1;
                }
            }
        }

        public int Count(string word)
        {
            return _frequency.ContainsKey(word) ? _frequency[word] : 0;
        }
    }
}
