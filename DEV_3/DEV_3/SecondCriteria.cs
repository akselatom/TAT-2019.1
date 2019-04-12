namespace DEV_3
{
    using System.Collections.Generic;

    /// <summary>
    /// Minimum cost with fixed productivity.
    /// </summary>
    public class SecondCriteria : SelectionCriteria
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecondCriteria"/> class.
        /// </summary>
        /// <param name="company">
        /// The company.
        /// </param>
        /// <param name="customer">
        /// The customer.
        /// </param>
        public SecondCriteria(Company company, Customer customer)
            : base(company, customer)
        {
        }

        /// <summary>
        /// Creates a new <see cref="List{T}"/> of <see cref="Employee"/>, based on the list of employees of the <see cref="Company"/>
        /// </summary>
        /// <returns>Returns a list of employees with a given performance and minimum cost</returns>
        public override List<Employee> SearchByCustomerCriteria()
        {
            int balance = this.Customer.AvailableMoney;
            List<Employee> newTeamList = new List<Employee>();
            List<Junior> companyEmployeeList = new List<Junior>(this.Company.CompanyEmployeesList);
            int requiredProductivity = this.Customer.RequiredProductivity;
            int currentProductivity = 0;
            while (requiredProductivity >= currentProductivity)
            {
                int index = this.FindMostEfficiencyEmployeeIndex(companyEmployeeList);
                if (companyEmployeeList[index].Salary < balance)
                {
                    newTeamList.Add(companyEmployeeList[index]);
                    currentProductivity += companyEmployeeList[index].Productivity;
                    companyEmployeeList.RemoveAt(index);
                }
                else
                {
                    companyEmployeeList.RemoveAt(index);
                }
            }

            return newTeamList;
        }
    }
}