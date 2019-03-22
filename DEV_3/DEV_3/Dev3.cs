
namespace DEV_3
{
    using System;

    /// <summary>
    /// The main class.
    /// Contains a entry point method of program.
    /// </summary>
    public class Dev3
    {
        /// <summary>
        /// The entry point of the program
        /// </summary>
        /// <param name="args">Entry string.Specified in the input argument string
        /// args[0] - customers available money
        /// args[1] - required productivity
        /// args[2] - criteria
        /// </param>
        public static void Main(string[] args)
        {
            try
            {
                if (args.Length < 2)
                {
                    throw new Exception("invalid input arguments");
                }

                if (!int.TryParse(args[0], out var availableMoney) || !int.TryParse(args[1], out var requiredProductivity)
                                                                  || !int.TryParse(args[2], out var selectedCriteria))
                {
                    throw new Exception("invalid input arguments");
                }

                Company company = new Company();
                Customer customer = new Customer(availableMoney, requiredProductivity);
                SelectionCriteria criteria;
                switch (selectedCriteria)
                {
                    case 1:
                        criteria = new FirstCriteria(company, customer);
                        break;
                    case 2:
                        criteria = new SecondCriteria(company, customer);
                        break;
                    case 3:
                        criteria = new ThirdCriteria(company, customer);
                        break;
                    default:
                        throw new Exception("incorrect criterion input! Should be 1,2 or 3!");
                }

                if (criteria.SearchByCustomerCriteria().Count > 0)
                {
                    foreach (var employee in criteria.SearchByCustomerCriteria())
                    {
                        Console.WriteLine(employee.GetInfo());
                    }
                }
                else
                {
                    Console.WriteLine("impossible to pick a team by criterion");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
