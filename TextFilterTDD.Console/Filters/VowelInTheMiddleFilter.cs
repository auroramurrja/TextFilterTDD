using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilterTDD.Console.Filters
{
    public class VowelInTheMiddleFilter : ITextFilter
    {
        public IEnumerable<string> Filter(string[] words)
        {
            IEnumerable<string> result = words.Where(HasVowelInTheMiddle)
                .Select(word => word);
            return result;
        }
        private bool HasVowelInTheMiddle(string word)
        {
            if(String.IsNullOrEmpty(word))
                return false;   
            string middle;
            int strLength = word.Length;
            if (strLength % 2 == 0)
                middle = word.Substring(strLength / 2 - 1, 2);
            middle = word.Substring(strLength / 2, 1);
            return HasVowel(middle);
        }
        private bool HasVowel(string str)
        {
            str = str.ToLower();
            return str.Contains('a') || str.Contains('e') || str.Contains('i') || str.Contains('o') || str.Contains('u') || str.Contains('y') || str.Contains('w');
        }
    }
}

