using System.Linq;

namespace _304_SortEvenNumber
{
    static class Program
    {
        static void Main(string[] args)
        {
            var result = Console.ReadLine().Split(", ").Select(int.Parse)
                .Where(x => x % 2 == 0).OrderBy(x => x);
            //Console.ReadLine().Split(',', ' ').MySelect(int.Parse);

            Console.WriteLine(string.Join(", ", result));

            //2, 4, 5, 7, 4, 6, 77, 77, 1
        }

        static List<T2> MySelect<T, T2>(this IEnumerable<T> input, Func<T, T2> projection)
        {
            var newList = new List<T2>();

            foreach (var element in input)
            {
                newList.Add(projection(element));
            }

            return newList;
        }
    }
}