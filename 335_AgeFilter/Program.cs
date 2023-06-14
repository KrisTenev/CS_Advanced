using System;
using System.Threading.Channels;

namespace _335_AgeFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            4
            Pesho, 20
            Mimi, 29
            Ico, 31
            Simo, 16
            older
            20
            name age
            */

            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var parts = line.Split(", ");
                var name = parts[0];
                var age = int.Parse(parts[1]);
                var person = new Person(name, age);
                people.Add(person);
            }

            var conditionString = Console.ReadLine();
            var conditionParameter = int.Parse(Console.ReadLine());

            Func<Person, bool> predicate = p => true;
            if (conditionString == "older")
            {
                predicate = p => p.Age > conditionParameter;
            }
            else if (conditionString == "younger")
            {
                predicate = p => p.Age < conditionParameter;
            }
            else if (conditionString == "exactly")
            {
                predicate = p => p.Age == conditionParameter;
            }

            var filteredPeople = people.Where(predicate);
            var format = Console.ReadLine();

            foreach (var person in filteredPeople)
            {
                var output = format.Replace("age", person.Age.ToString()).Replace("name", person.Name);
                Console.WriteLine(output);
            }
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
        }
    }
}