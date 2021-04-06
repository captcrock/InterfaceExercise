using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : ICompany, IVehicle
    {
        public string TypeOfBed { get; set; }
        public bool FWD { get; set; }
        public string MainColor { get; set; }
        public bool WorldWide { get; set; }
        public int NumberOfDoors { get; set; }
        public int TireSize { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }

    }
}
