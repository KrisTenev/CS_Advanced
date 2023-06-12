using System.IO.MemoryMappedFiles;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _302_LambdaExpressions
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsEvenNumber(5));
            Console.WriteLine(IsEvenNumber(10));

            Func<int, bool> predicate = IsEvenNumber;
            predicate(1);

            Func<int, bool> predicate2 = x => x % 2 == 0;
            predicate(2);


            var newCollection = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.Where(predicate2);
            Console.WriteLine(string.Join(", ", newCollection));

            var newCollection2 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.Where(x => x % 2 == 0);
            Console.WriteLine(string.Join(", ", newCollection2));

            var newCollection3 = MyWhere(new[] { 1.2, 2.0, 3.5, 4.0, 5.1, 6.0, 7.0, 8.9, 9.2, 10.6 }, x => x % 2 == 0);
            Console.WriteLine(string.Join(", ", newCollection3));

            var input = new[] { 1.2, 2.0, 3.5, 4.0, 5.1, 6.0, 7.0, 8.9, 9.2, 10.6 };
            var newCollection4 = input.MyWhere(x => x % 2 == 0);
            Console.WriteLine(string.Join(", ", newCollection4));
        }

        static List<T> MyWhere<T>(this IEnumerable<T> input, Func<T, bool> filter)
        {
            var newList = new List<T>();
            foreach (var number in input)
            {
                if (filter(number))
                {
                    newList.Add(number);
                }
            }

            return newList;
        }

        static bool IsEvenNumber(int x) => x % 2 == 0;

        static bool IsEvenNumber2(int x)
        {
            return x % 2 == 0;
        }

    }
}