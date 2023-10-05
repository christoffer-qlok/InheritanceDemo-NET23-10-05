using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal sealed class JuniorHourlyEmployee : HourlyEmployee
    {
        public JuniorHourlyEmployee(string name, double hourlySalary) : base(name, hourlySalary)
        {
        }
    }
}
