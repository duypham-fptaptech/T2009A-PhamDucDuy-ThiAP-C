using System;
using System.Text.RegularExpressions;

namespace Excercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SearchWord();
        }

        private static void SearchWord()
        {
            Console.WriteLine("Enter a String");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter a word to search");
            string word2 = Console.ReadLine();
            int time = Regex.Matches(word1, word2).Count;
            Console.WriteLine($"Word found {time} times in the string");
        } 
    }
}