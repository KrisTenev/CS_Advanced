using MyHashFunction;
using System.Diagnostics;
using System.Text;


// Build for List
int count = 100000;
int containsCount = 10000;

List<string> list = new List<string>(count);
HashSet<string> hash = new HashSet<string>(count);
StringHashSet myHash = new StringHashSet(count);

for (int i = 0; i < count; i++)
{
    list.Add(i.ToString());
    hash.Add(i.ToString());
    myHash.Add(i.ToString());
}

Console.WriteLine("Start!");
var timer = Stopwatch.StartNew();

//List
for (int i = 0; i < containsCount; i++)
{
	bool exist = list.Contains(i.ToString());
}
timer.Stop();
Console.WriteLine("List sucks!");
Console.WriteLine(timer.ElapsedMilliseconds);
timer.Reset();
timer.Start();

//C# Hash
for (int i = 0; i < containsCount; i++)
{
    bool exist = hash.Contains(i.ToString());
}
timer.Stop();
Console.WriteLine("C# is OK!");
Console.WriteLine(timer.ElapsedMilliseconds);
timer.Reset();
timer.Start();

//My Hash
for (int i = 0; i < containsCount; i++)
{
    bool exist = myHash.Contains(i.ToString());
}
timer.Stop();
Console.WriteLine("myHash is the best!");
Console.WriteLine(timer.ElapsedMilliseconds);
timer.Reset();
timer.Start();

static string GenerateString(int length = 8)
{
	StringBuilder sb = new StringBuilder();
	Random rand = new Random();
	for (int i = 0; i < length; i++)
	{
		sb.Append(rand.Next(0, 9));
	}

	return sb.ToString();
}
