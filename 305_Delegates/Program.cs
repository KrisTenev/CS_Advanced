using System.Threading.Channels;

namespace _305_Delegates
{
    static class Program
    {
        static void Main(string[] args)
        {
            IntPredicate intPredicateVariable = x => x % 2 == 0;
            Func<int, bool> intPredicateVar = x => x % 2 == 1;
            Action hello = () => Console.WriteLine("hello");
            Action<string> print = (message) => Console.WriteLine(message);

            var result = Console.ReadLine().Split(", ").Select(Parse);
            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine(result.Count());
            Console.WriteLine(result.Sum());
        }

        delegate bool IntPredicate(int x);
        delegate void DoSomething(string s);

        static int Parse(string str)
        {
            int number = 0;

            foreach (var ch in str)
            {
                number *= 10;
                number += ch - '0';
            }

            return number;
        }
    }
}
