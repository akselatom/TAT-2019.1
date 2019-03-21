namespace DEV_3
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class SelectionCriteria
    {
        /// <summary>
        /// field containing information about the customer
        /// </summary>
        private Customer customer;
        
        /// <summary>
        /// field containing information about the company
        /// </summary>
        private Company company;

        public Customer GetCustomer
        {
            get
            {
                return this.customer;
            }
        }

        public Company GetCompany
        {
            get
            {
                return this.company;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionCriteria"/> class.
        /// </summary>
        /// <param name="company">
        /// The company.
        /// </param>
        /// <param name="customer">
        /// The customer.
        /// </param>
        protected SelectionCriteria(Company company,Customer customer)
        {
            this.company = company;
            this.customer = customer;
        }

        public virtual List<Employee> CustomerCriteria()
        {
            return null;
        }
    }
    
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

        public override List<Employee> CustomerCriteria()
        {
            int balance = this.GetCustomer.GetAvailableMoney;
            List<Employee> newTeamList = new List<Employee>();
            List<Junior> companyEmployeeList = this.GetCompany.GetCompanyEmployeesList;
            Junior junior = new Junior();
            int numberOfEmployess = this.GetCompany.GetNumberOfEmployees;
            int counter = 0;
            while (numberOfEmployess > counter && junior.GetSalary < balance)
            {
                counter++;
                int index = this.FindMostEfficiencyEmployeeIndex(companyEmployeeList);
                if (companyEmployeeList[index].GetSalary < balance)
                {
                    newTeamList.Add(companyEmployeeList[index]);
                    balance -= companyEmployeeList[index].GetSalary;
                    companyEmployeeList.RemoveAt(index);
                }
                else
                {
                    companyEmployeeList.RemoveAt(index);
                }
            }
            return newTeamList;
        }

        /// <summary>
        /// find the most efficiency employee index.
        /// </summary>
        /// <param name="list">
        /// list of employees
        /// </param>
        /// <returns>
        /// returns the index of the most efficient employee
        /// </returns>
        private int FindMostEfficiencyEmployeeIndex(List<Junior> list)
        {
            double max = list[0].GetEfficiencyCoefficient;
            int index = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (max < list[i].GetEfficiencyCoefficient)
                {
                    max = list[i].GetEfficiencyCoefficient;
                    index = i;
                }
            }

            return index;
        }
    }
}