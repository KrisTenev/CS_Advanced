
using Classes;
using System.Runtime.CompilerServices;

Dog sharoDog = new Dog();

sharoDog.Name = "Sharo";
sharoDog.Age = 7;


Dog peshoDog = new Dog();

sharoDog.Name = "Pesho";

Cat kittyCat = new Cat();

kittyCat.Name = "Macka";

NewTest();

static void NewTest()
{

}

internal class Cat
{
    //Properties
    public string Name { get; set; }
    public int Age { get; set; }
    public bool HadOwner { get; set; }

    class SomeInnerClass
    {

    }

}