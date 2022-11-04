using System;
using System.Collections.Generic;
using System.Text;

namespace Task___Implicit___DataTime.Models.Temperatures
{
    public class Celcius
    {
        public double Degree_C { get; set; }

        public Celcius(double degreeC)
        {
            Degree_C = degreeC;
        }

        public static implicit operator Kelvin(Celcius celcius1)
        {
            return new Kelvin(celcius1.Degree_C + 273);
        }
    }
}
