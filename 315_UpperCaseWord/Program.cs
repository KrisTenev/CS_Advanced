using System;

namespace _315_UpperCaseWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text  = Console.ReadLine();
            var words = text.Split(new char[] { ' ', ',', '!', '.', '?', ':' }, StringSplitOptions.RemoveEmptyEntries);

            var capitalWords = words.Where(word => char.IsUpper(word[0]));

            foreach (var word in capitalWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}