using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfDoors { get; set; }
        public int TireSize { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
    }
}
