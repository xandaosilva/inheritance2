using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Inheritance2.Entities
{
    class Employee
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " - $ " + Payment().ToString("F2",CI));
            return sb.ToString();
        }
    }
}
