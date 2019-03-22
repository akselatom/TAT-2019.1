namespace DEV_3
{
    using System.Collections.Generic;

    /// <summary>
    /// Gives a <see cref="List{T}"/>of <see cref="Employee"/> depending on <see cref="Customer"/> requirements
    /// </summary>
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

        /// <summary>
        /// Gets the customer.
        /// </summary>
        public Customer GetCustomer
        {
            get
            {
                return this.customer;
            }
        }

        /// <summary>
        /// Gets the company.
        /// </summary>
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

        /// <summary>
        /// finds a <see cref="Employee"/> with maximum efficiency in the input list
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        /// <returns>
        /// Returns the index of the most efficiency <see cref="Employee"/>
        /// </returns>
        protected int FindMostEfficiencyEmployeeIndex(List<Junior> list)
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
    }

    /// <summary>
    /// Minimum cost with fixed productivity.
    /// </summary>
    public class SecondCriteria: SelectionCriteria
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
        public override List<Employee> CustomerCriteria()
        {
            int balance = this.GetCustomer.GetAvailableMoney;
            List<Employee> newTeamList = new List<Employee>();
            List<Junior> companyEmployeeList = new List<Junior>(this.GetCompany.GetCompanyEmployeesList);
            int requiredProductivity = this.GetCustomer.GetRequiredProductivity;
            int currentProductivity = 0;
            while (requiredProductivity >= currentProductivity)
            {
                int index = this.FindMostEfficiencyEmployeeIndex(companyEmployeeList);
                if (companyEmployeeList[index].GetSalary < balance)
                {
                    newTeamList.Add(companyEmployeeList[index]);
                    currentProductivity += companyEmployeeList[index].GetProductivity;
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

    /// <summary>
    /// Minimum number of staff qualifications above Junior for fixed productivity.
    /// </summary>
    public class ThirdCriteria: SelectionCriteria
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdCriteria"/> class.
        /// </summary>
        /// <param name="company">
        /// The company.
        /// </param>
        /// <param name="customer">
        /// The customer.
        /// </param>
        public ThirdCriteria(Company company, Customer customer)
            : base(company, customer)
        {
        }

        /// <summary>
        /// Creates a new list of employees, based on the list of employees of the <see cref="Company"/>
        /// </summary>
        /// <returns>
        /// Returns a list of employees with a given performance and minimum number of employees.
        /// </returns>
        public override List<Employee> CustomerCriteria()
        {

            List<Employee> newTeamList = new List<Employee>();
            List<Junior> companyEmployeeList = new List<Junior>(this.GetCompany.GetCompanyEmployeesList);
            int requiredProductivity = this.GetCustomer.GetRequiredProductivity;
            int currentProductivity = 0;
            while (currentProductivity <= requiredProductivity)
            {
                ////finds the index of the most productive employee of the company, adds it to the newTeamList
                int index = this.GetMaxProductivityEmployeeIndex(companyEmployeeList);
                newTeamList.Add(companyEmployeeList[index]);
                currentProductivity += companyEmployeeList[index].GetProductivity;
                ////removes employee from companyEmployeeList
                companyEmployeeList.RemoveAt(index);

            }

            return newTeamList;
        }

        /// <summary>
        /// finds a <see cref="Employee"/> with maximum productivity in the input list
        /// </summary>
        /// <param name="list">Input <see cref="Junior"/> list </param>
        /// <returns>returns the index of the most productive <see cref="Employee"/></returns>
        private int GetMaxProductivityEmployeeIndex(List<Junior> list)
        {
            int index = 0;

            int maxProductivity = list[index].GetProductivity;
            for (int i = 0; i < list.Count; i++)
            {
                if (maxProductivity < list[i].GetProductivity)
                {
                    if (list[i].GetType() != typeof(Junior))
                    {
                        maxProductivity = list[i].GetProductivity;
                        index = i;
                    }
                }
            }

            return index;
        }
    }
}