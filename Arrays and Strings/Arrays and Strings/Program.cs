using Arrays_and_Strings.Helpers;
using System.Runtime.CompilerServices;

Console.WriteLine("hello world!");

string test = "8143275";
char[] chars = test.ToCharArray();

QuickSort.QuickSortCharacters(chars, 0, chars.Length - 1);

foreach (char c in chars)
{
    Console.WriteLine(c);
}
