using _403_CarManufacurer;

//Car car = new Car();
//car.Make = "BMW";
//car.Year = 2021;
//car.Model = "e39";
//car.FuelConsumpltion = 12;
//car.FuelQuantity = 200;

Car defaultCar = new Car();
Engine engine = new Engine(150, 2000);
Tire[] tires = new Tire[]
{
    new Tire(2008, 20),
    new Tire(2009, 20),
    new Tire(2010, 25),
    new Tire(2020, 40),
};

Car bmwE = new Car("BMW", "e39", 2001, 200, 12, engine, tires);
Car bmwX = new Car("BMW", "X3", 1999);

bmwE.Drive(20);
bmwE.Drive(10);
Console.WriteLine(defaultCar.WhoAmI());
Console.WriteLine(bmwE.WhoAmI());
Console.WriteLine(bmwX.WhoAmI());

