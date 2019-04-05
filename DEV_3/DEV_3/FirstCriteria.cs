namespace DEV_3
{
    using System.Collections.Generic;

    /// <summary>
    /// Contains methods for finding the team composition with a maximum performance within the sum
    /// </summary>
    public class FirstCriteria : SelectionCriteria
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirstCriteria"/> class.
        /// </summary>
        /// <param name="company">
        /// The company.
        /// </param>
        /// <param name="customer">
        /// The customer.
        /// </param>
        public FirstCriteria(Company company, Customer customer)
            : base(company, customer)
        {
        }

        /// <summary>
        /// Creates a new <see cref="List{T}"/> of <see cref="Employee"/>, based on the list of employees of the <see cref="Company"/>
        /// </summary>
        /// <returns>
        /// <returns>Returns a <see cref="List{T}"/> of <see cref="Employee"/> with a with a maximum performance within the sum</returns>
        /// </returns>
        public override List<Employee> SearchByCustomerCriteria()
        {
            int balance = this.Customer.AvailableMoney;
            List<Employee> newTeamList = new List<Employee>();
            List<Junior> companyEmployeeList = this.Company.CompanyEmployeesList;
            Junior junior = new Junior();
            int numberOfEmployes = this.Company.NumberOfEmployees;
            int counter = 0;
            while (numberOfEmployes > counter && junior.Salary < balance)
            {
                counter++;
                int index = this.FindMostEfficiencyEmployeeIndex(companyEmployeeList);
                if (companyEmployeeList[index].Salary < balance)
                {
                    newTeamList.Add(companyEmployeeList[index]);
                    balance -= companyEmployeeList[index].Salary;
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