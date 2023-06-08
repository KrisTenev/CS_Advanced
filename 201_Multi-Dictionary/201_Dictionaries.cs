
/*
 * Associative Arrays (Maps, Dictionaries)
 * Dictionary<K,V>
 * 
 * SortedDictionary<K,V>
 * Uses a balanced search tree (red-black tree)?
 * 
 * dict.Add
 * dict.Remove
 * dict.ContainsKey
 * dict.ContainsValue (slow operation, not recomended)
*/

using System.Linq;

SortedDictionary<string,int> kiwi = new SortedDictionary<string, int>();
//Dictionary<string,int> kiwi = new Dictionary<string, int>();

kiwi["green"] = 1;
kiwi["ap"] = 2;
kiwi.Add("bp", 3);
kiwi.Remove("green");

CountDictValues();

static void CountDictValues()
{
    double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

    Dictionary<double, int> times = new Dictionary<double, int>();

    for (int i = 0; i < numbers.Length; i++)
    {
        if (!times.ContainsKey(numbers[i]))
        {
            times.Add(numbers[i], 0);
        }

        times[numbers[i]]++;
    }

    foreach (var item in times)
    {
        Console.WriteLine($"{item.Key} - {item.Value} times");
    }
}

static void PrintDict(Dictionary<double, int>  dict)
{
    foreach (var kvp in dict)
    {
        Console.WriteLine($"{kvp.Key} = {kvp.Value}");
    }
}
