
using System.Text.RegularExpressions;
using TextFilterTDD.Console.Filters;

Console.WriteLine("Hello Text Filters");
string allText ="";
try
{
    var currentDirectory = Directory.GetCurrentDirectory();
    var path = currentDirectory + "\\TextInput.txt";
    allText = System.IO.File.ReadAllText(path);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

allText = Regex.Replace(allText, "[^a-zA-Z_]+", " ");
string[] words = allText.Split(" ");
//filter1 
Console.WriteLine();
Console.WriteLine("VowelInTheMiddleFilter");
VowelInTheMiddleFilter vowelInTheMiddleFilter = new VowelInTheMiddleFilter();
var vowelInTheMiddleWords = vowelInTheMiddleFilter.Filter(words);
foreach(var el in vowelInTheMiddleWords)
Console.WriteLine(el);
//filter2
Console.WriteLine();
Console.WriteLine("LengthLessThan3Filter");
LengthLessThan3Filter lengthLessThan3Filter = new LengthLessThan3Filter();
var lengthLessThan3Words = lengthLessThan3Filter.Filter(words);
foreach (var el in lengthLessThan3Words)
    Console.WriteLine(el);
//filter3
Console.WriteLine();
Console.WriteLine("ContainsLetterTfilter");
ContainsLetterTfilter containsLetterTfilter = new ContainsLetterTfilter();
var containsLetterTWords = containsLetterTfilter.Filter(words); 
foreach(var el in containsLetterTWords)
Console.WriteLine(el);

Console.ReadLine(); 



