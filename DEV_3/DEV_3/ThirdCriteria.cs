namespace DEV_3
{
    using System.Collections.Generic;

    /// <summary>
    /// Minimum number of staff qualifications above Junior for fixed productivity.
    /// </summary>
    public class ThirdCriteria : SelectionCriteria
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
        public override List<Employee> SearchByCustomerCriteria()
        {
            List<Employee> newTeamList = new List<Employee>();
            List<Junior> companyEmployeeList = new List<Junior>(this.Company.CompanyEmployeesList);
            int requiredProductivity = this.Customer.RequiredProductivity;
            int currentProductivity = 0;
            while (currentProductivity < requiredProductivity)
            {
                ////finds the index of the most productive employee of the company, adds it to the newTeamList
                int index = this.GetMaxProductivityEmployeeIndex(companyEmployeeList);
                newTeamList.Add(companyEmployeeList[index]);
                currentProductivity += companyEmployeeList[index].Productivity;
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

            int maxProductivity = list[index].Productivity;
            for (int i = 0; i < list.Count; i++)
            {
                if (maxProductivity < list[i].Productivity)
                {
                    if (list[i].GetType() != typeof(Junior))
                    {
                        maxProductivity = list[i].Productivity;
                        index = i;
                    }
                }
            }

            return index;
        }
    }
}