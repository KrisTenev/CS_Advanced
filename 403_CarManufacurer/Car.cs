using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _403_CarManufacurer
{
    public class Car
    {
        //Fields
        //private string make;
        //private string model;
        //private int year;
        //private double fuelQuantity;
        //private double fuelConsumpltion;

        //Constructors - initialize Class statements
        public Car()
        {
            Make = "None";
            Model = "NoModel";
            Year = 0;
            FuelQuantity = 0;
            FuelConsumpltion = 0;
        }
        public Car(string make) : this()
        {
            Make = make;            
        }
        public Car(string make, string model, int year) : this(make)
        {
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumpltion) : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumpltion = fuelConsumpltion;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumpltion, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumpltion)
        {
            Engine = engine;
            Tires = tires;
        }

        //Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumpltion { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }
        //Methods
        public void Drive(double distance)
        {
            double consumption = distance * this.FuelConsumpltion;

            if (FuelQuantity - consumption <= 0)
            {
                Console.WriteLine("Not enough fuel to perform this trip.\n");
            }
            else
            {
                this.FuelQuantity -= consumption;
            }
        }
        public string WhoAmI()
        {
            var output = $"Make:\t{this.Make}\nModel:\t{this.Model}\nYear:\t{this.Year}\nFuel:\t{this.FuelQuantity:F2}L\n";
            return output;
        }
    }
}
