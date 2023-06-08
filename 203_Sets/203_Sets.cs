/*
 * A Set keeps unique elements
 * Set has no indexes
 * Add, Remove, Search
 * Very fast performnace
 * 
 * HashSet<T>
 * - keeps a set of elements in a hash-table
 * - elements are in no order
 */

using Set_T_;

HashSet<int> numbers = new HashSet<int>();
numbers.Add(5);
numbers.Add(3);
numbers.Add(5);
numbers.Add(1);
numbers.Add(1);
numbers.Remove(5);
numbers.Contains(1);

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine();

SortedSet<int> numbers2 = new SortedSet<int>(); //keeps elemtns sorted, but is slow than HashSet<T>
numbers2.Add(5);
numbers2.Add(1);
numbers2.Add(3);
numbers2.Add(5);
numbers2.Add(1);
numbers2.Remove(5);
numbers2.Contains(1);
foreach (var number in numbers2)
{
    Console.WriteLine(number);
}

Person Ivan = new Person();
Ivan.Name = "Test";
Console.WriteLine(Ivan.Name);
