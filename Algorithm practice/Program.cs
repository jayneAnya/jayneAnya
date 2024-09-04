// See https://aka.ms/new-console-template for more information
using Algorithm_practice;

Console.WriteLine("Hello, World!");
var input = "www.dec8agon12.com";
var inp = new List<string> { "wellness", "Awesome" };
string str = "www.goggle1.com/axxess2";
int fib = 10;

var listOfNumbersInString = Algos.FindNumbersInString(input);
var commonCharacters = Algos.FindCommonChars(inp);
var extractNumber = Algos.ExtNum(str);
var reverseString = Algos.RevString(str);
bool iSPalindrome = Algos.IsPalindrome(str);
Algos.FiboNumbers(fib);



Console.WriteLine("Extracted numbers:");
foreach (int number in listOfNumbersInString)
{
    Console.WriteLine($"This is the output: {number}");
}

foreach (char character in commonCharacters)
{
    Console.WriteLine($"This is the output of the character: {character}");
}
Console.WriteLine(extractNumber);
Console.WriteLine(reverseString);
Console.WriteLine(iSPalindrome);




