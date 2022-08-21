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
            return IsVowel(middle);
        }
        private bool IsVowel(string str)
        {
            str = str.ToLower();
            char[] characters = str.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == 'a' || characters[i] == 'e' || characters[i] == 'i' || characters[i] == 'o' || characters[i] == 'u' || characters[i] == 'y' || characters[i] == 'w')
                    return true;
            }
            return false;
        }
    }
}

