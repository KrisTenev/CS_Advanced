using _402_Students;

Student student = new Student();
student.Name = "Doncho";
Console.WriteLine(student.Name);

Dog dog = new Dog();
dog.Name = "Dog Dogov";
dog.Age = 5;
dog.BitePerson();
dog.BitePerson();

bool isBadDog = dog.IsBadDog;

Console.WriteLine(student.Name + " has dog: " + dog.Name);
Console.WriteLine(dog.Age);
Console.WriteLine(dog.IsBadDog);
