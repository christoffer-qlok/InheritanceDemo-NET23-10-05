using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal abstract class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public virtual void Work()
        {
            Console.WriteLine("Generic employee working");
        }

        public abstract double GetSalary();
    }
}
