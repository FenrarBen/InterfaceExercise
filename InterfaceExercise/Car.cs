using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle, ICompany
    {
        public int TrunkSize { get; set; }
        public bool HasSpareTire { get; set; }
        public int NumTires { get; set; }
        public string Model { get; set; }
        public int NumDoors { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public string Slogan { get; set; }
    }
}
