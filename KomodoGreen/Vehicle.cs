using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreen
{
    public class Vehicle
    {
        public string Type { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double MPG { get; set; }

        public Vehicle() { }

        public Vehicle(string type, string make, string model, int year, double mpg)
        {
            Type = type;
            Make = make;
            Model = model;
            Year = year;
            MPG = mpg;
        }
    }
}