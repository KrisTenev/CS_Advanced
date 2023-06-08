/*
 * var grades = new Dictionary<string, List<int>>();
 * 
 */

using System.Diagnostics;
using System.Net.WebSockets;
using System.Text;

Cities();

static void AverageStudentGrade()
{
    Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

    int students = int.Parse(Console.ReadLine());

    for (int i = 0; i < students; i++)
    {
        string[] input = Console.ReadLine().Split();
        string name = input[0];
        decimal grade = decimal.Parse(input[1]);

        if (!grades.ContainsKey(name))
        {
            grades.Add(name, new List<decimal>());
        }

        grades[name].Add(grade);
    }

    foreach (var kvp in grades)
    {
        StringBuilder formatGrades = new StringBuilder();
        for (int i = 0; i < kvp.Value.Count ; i++)
        {
            formatGrades.Append($"{kvp.Value[i]:f2} ");
        }

        Console.WriteLine($"{kvp.Key} -> {formatGrades.ToString().Trim()} (avg: {kvp.Value.Average():f2})");
    }
}

static void ProductShop()
{
    var shops = new Dictionary<string, Dictionary<string, double>>();

    string[] input = Console.ReadLine().Split(", ");

    while (input[0] != "Revision")
    {
        string shop = input[0];
        string product = input[1];
        double price = double.Parse(input[2]);

        if (!shops.ContainsKey(shop))
        {
            shops.Add(shop, new Dictionary<string, double>());
        }

        if (!shops[shop].ContainsKey(product))
        {
            shops[shop].Add(product, price);
        }

        input = Console.ReadLine().Split(", ");
    }

    //Sort second Dictionary by Key
    shops = shops.OrderBy(x => x.Key).ToDictionary(x => x.Key, s => s.Value);
    var keys = shops.Select(x => x.Key).ToList();
    for (int i = 0; i < keys.Count; i++)
    {
        shops[keys[i]] = shops[keys[i]].OrderBy(x => x.Key).ToDictionary(x => x.Key, s => s.Value);
    }

    //Print result
    foreach (var shop in shops)
    {
        Console.WriteLine($"{shop.Key} ->");

        foreach (var product in shop.Value)
        {
            Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
        }
    }
}

static void Cities()
{
    Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();
    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        var input = Console.ReadLine().Split();

        if (!continents.ContainsKey(input[0]))
        {
            continents.Add(input[0], new Dictionary<string, List<string>>());
        }

        if (!continents[input[0]].ContainsKey(input[1]))
        {
            continents[input[0]].Add(input[1], new List<string>());
        }

        continents[input[0]][input[1]].Add(input[2]);
    }

    foreach (var continent in continents)
    {
        Console.WriteLine($"{continent.Key}:");

        foreach (var country in continent.Value)
        {
            Console.WriteLine($"  {country.Key} -> {String.Join(", ", country.Value)}");
        }
    }
}

