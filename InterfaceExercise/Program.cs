using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car car = new Car();
            Truck truck = new Truck();
            SUV suv = new SUV();

            car.TrunkSize = 20;
            car.Model = "Focus";
            car.Name = "Ford";
            car.NumTires = 4;
            car.Slogan = "Built Ford Tough";
            car.Year = 2014;
            car.NumDoors = 4;
            car.HasSpareTire = true;

            truck.Model = "Ford";
            truck.Name = "F150";
            truck.NumDoors = 4;
            truck.NumTires = 4;
            truck.BedSize = 40;
            truck.Slogan = "Built Ford Tough";
            truck.TowCapacity = 2900;
            truck.Year = 2020;

            suv.Model = "Griffin";
            suv.Name = "Ascalon";
            suv.NumTires = 8;
            suv.HasEScreen = true;
            suv.Slogan = "I eat people";
            suv.NumDoors = 12;
            suv.Year = 2150;
            suv.CargoSpace = 0;

            Console.WriteLine("Display all long and drawn out properties here, like so: ");
            Console.WriteLine($"This SUV is made by {suv.Name} in the year {suv.Year}.");
            Console.WriteLine($"It has {suv.NumDoors} doors and {suv.NumTires} tires.");
            Console.WriteLine("That's all to see here.");


        }
    }
}
