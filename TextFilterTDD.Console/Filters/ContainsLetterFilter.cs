using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilterTDD.Console.Filters
{
    public class ContainsLetterFilter : ITextFilter
    {
        private readonly char _letter;
        public ContainsLetterFilter(char letter)
        {
            _letter = letter;
        }

        public IEnumerable<string> Filter(string[] words)
        {
            IEnumerable<string> result = from word in words where word.ToLower().Contains(_letter) select word;
            return result;
        }
    }
}
