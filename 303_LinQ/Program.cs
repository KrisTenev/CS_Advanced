
var input = new[] { 100, 102, 108, 110 };
var result = input.Where((x,i) => i % 2 == 0 || x % 2 == 0);
Console.WriteLine(string.Join(", ", result));

var input2 = new int[][]
{
    new[] { 1, 2 ,3, 4 },
    new[] { 2, 3 ,4, 5, 6, 7, 8 },
    new[] { 0 },
};
var result2 = input2.Where(x => x.Any(y => y == 8));
Console.WriteLine(string.Join(", ", result2.FirstOrDefault() ?? new int[0]));




