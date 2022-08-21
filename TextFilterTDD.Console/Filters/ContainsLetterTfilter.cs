using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilterTDD.Console.Filters
{
    public class ContainsLetterTfilter : ITextFilter
    {
        public IEnumerable<string> Filter(string[] words)
        {
            IEnumerable<string> result = from word in words where word.ToLower().Contains('t') select word;
            return result;
        }
    }
}
