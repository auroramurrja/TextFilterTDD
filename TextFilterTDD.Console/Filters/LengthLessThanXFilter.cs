using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilterTDD.Console.Filters
{
    public class LengthLessThanXFilter : ITextFilter
    {
        private readonly int _length;   
        public LengthLessThanXFilter(int length)
        {
            _length = length;
        }
    
        public IEnumerable<string> Filter(string[] words)
        {
            IEnumerable<string> result = from word in words where word.Length<_length select word;
            return result;  
        }
    }
}
