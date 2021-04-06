using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : ICompany, IVehicle
    {
        public bool AWD { get; set; }
        public int NumberOfSeats { get; set; }
        public string MainColor { get; set; }
        public bool WorldWide { get; set; }
        public int NumberOfDoors { get; set; }
        public int TireSize { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
    }
}
