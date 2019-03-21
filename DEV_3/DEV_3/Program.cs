
namespace DEV_3
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Company newCompany = new Company();
            Customer newCustomer = new Customer(200, 100);
            SelectionCriteria newCriteria = new FirstCriteria(newCompany, newCustomer);
            foreach (var employee in newCriteria.CustomerCriteria())
            {
                Console.WriteLine(
                    employee.GetName + " " + employee.GetType().ToString()
                        .Substring(employee.GetType().ToString().LastIndexOf('.')));
            }
        }
    }
}
