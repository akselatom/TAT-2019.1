
namespace DEV_3
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            Company newCompany = new Company();
            Customer newCustomer = new Customer(200, 100);
            SelectionCriteria newCriteria = new ThirdCriteria(newCompany, newCustomer);
            foreach (var employee in newCriteria.CustomerCriteria())
            {
                StringBuilder consoleOutputString = new StringBuilder();
                consoleOutputString.AppendFormat(employee.GetName);
                consoleOutputString.Append(" ");
                consoleOutputString.AppendFormat(
                    employee.GetType().ToString().Substring(employee.GetType().ToString().LastIndexOf('.')));
                Console.WriteLine(consoleOutputString);
            }
        }
    }
}
