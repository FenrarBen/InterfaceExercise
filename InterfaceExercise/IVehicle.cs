using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int NumTires { get; set; }
        public string Model { get; set; }
        public int NumDoors { get; set; }
        public int Year { get; set; }
    }
}
