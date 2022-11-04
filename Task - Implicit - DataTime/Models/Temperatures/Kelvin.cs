using System;
using System.Collections.Generic;
using System.Text;

namespace Task___Implicit___DataTime.Models.Temperatures
{
    public class Kelvin
    {
        public double Degree_K { get; set; }

        public Kelvin(double degreeK)
        {

            Degree_K = degreeK;
        }
    }
}
