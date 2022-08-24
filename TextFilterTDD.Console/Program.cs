
using System.Text.RegularExpressions;
using TextFilterTDD.Console.Filters;

Console.WriteLine("Hello Text Filters");
string? allText ="";
try
{
    var path = Directory.GetCurrentDirectory() + "\\TextInput.txt";
    allText = await File.ReadAllTextAsync(path);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
allText = Regex.Replace(allText, "[^a-zA-Z_]+", " ");
string[] words = allText.Split(" ");
//filter1 
VowelInTheMiddleFilter vowelInTheMiddleFilter = new VowelInTheMiddleFilter();
FilterandPrintWords(vowelInTheMiddleFilter, words);
//filter2
LengthLessThanXFilter lengthLessThan3Filter = new LengthLessThanXFilter(3);
FilterandPrintWords(lengthLessThan3Filter, words);
//filter3
ContainsLetterFilter containsLetterTfilter = new ContainsLetterFilter('t');
FilterandPrintWords(containsLetterTfilter, words);

Console.ReadLine();

void FilterandPrintWords(ITextFilter obj, string[] wordsArr)
{
    Console.WriteLine();
    Console.WriteLine(obj.GetType());
    var filteredWords = obj.Filter(wordsArr);
    foreach (var el in filteredWords)
        Console.WriteLine(el);
}