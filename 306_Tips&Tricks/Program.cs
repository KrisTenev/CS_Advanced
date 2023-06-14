

var numbers = Enumerable.Range(1, 100)
    .Where(x => x % 6 == 0)
    .OrderBy(x => x % 10)
    .Select(x => x / 6);

//Console.WriteLine(string.Join(" ", numbers));



var numbers2 = Enumerable.Range(1, 100)
    .GroupBy(x => x.ToString().Length)
    .ToDictionary(g => g.Key, g => g.ToList());

foreach (var kvp in numbers2)
{
    Console.WriteLine($"{kvp.Key} => {string.Join(", ", kvp.Value)}");
}

//Console.WriteLine(string.Join(", ", numbers2));

