
namespace DEV_3
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            Company newCompany = new Company();
            Customer newCustomer = new Customer(200, 150);
            SelectionCriteria newCriteria = new ThirdCriteria(newCompany, newCustomer);
            foreach (var employee in newCriteria.CustomerCriteria())
            {
                Console.WriteLine(employee.GetInfo());
            }
            
        }
    }
}
