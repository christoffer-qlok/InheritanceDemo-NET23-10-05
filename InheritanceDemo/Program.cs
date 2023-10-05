namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new HourlyEmployee("Christoffer", 100)
            {
                HoursWorked = 20,
            };

            employee.Work();
            Console.WriteLine($"Salary is {employee.GetSalary()}");

        }
    }
}