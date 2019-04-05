namespace DEV_3
{
    using System.Collections.Generic;

    /// <summary>
    /// Gives a <see cref="List{T}"/>of <see cref="Employee"/> depending on <see cref="DEV_3.Customer"/> requirements
    /// </summary>
    public abstract class SelectionCriteria
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionCriteria"/> class.
        /// </summary>
        /// <param name="company">
        /// The company.
        /// </param>
        /// <param name="customer">
        /// The customer.
        /// </param>
        protected SelectionCriteria(Company company, Customer customer)
        {
            this.Company = company;
            this.Customer = customer;
        }

        /// <summary>
        /// Gets a field containing information about the customer
        /// </summary>
        public Customer Customer { get; private set; }
        
        /// <summary>
        /// Gets a field containing information about the company
        /// </summary>
        public Company Company { get; private set; }

        /// <summary>
        /// The search by customer criteria.
        /// </summary>
        /// <returns>
        /// The <see cref="List{T}"/> of <see cref="Employee"/> matching by search criteria
        /// </returns>
        public virtual List<Employee> SearchByCustomerCriteria()
        {
            return new List<Employee>();
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
}