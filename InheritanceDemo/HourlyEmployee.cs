using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class HourlyEmployee : Employee
    {
        public double HourlySalary { get; set; }
        public int HoursWorked { get; set; }

        public HourlyEmployee(string name, double hourlySalary) : base(name)
        {
            HourlySalary = hourlySalary;
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is working hourly and billing");
        }

        public override double GetSalary()
        {
            return HoursWorked * HourlySalary;
        }
    }
}
