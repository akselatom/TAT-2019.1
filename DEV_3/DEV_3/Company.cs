namespace DEV_3
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The company that provides services to the customer, contains a list of employees
    /// </summary>
    public class Company
    {
        /// <summary>
        /// The number of employees.
        /// </summary>
        private int NumberOfEmployees = 0;

        /// <summary>
        /// Number of employees with qualifications <see cref="Lead"/>
        /// </summary>
        private int leadEmployeeCount = 1;

        /// <summary>
        /// Number of employees with qualifications <see cref="Senior"/>
        /// </summary>
        private int seniorEmployeeCount = 2;

        /// <summary>
        /// Number of employees with qualifications <see cref="Middle"/>
        /// </summary>
        private int middleEmployeeCount = 4;

        /// <summary>
        /// Number of employees with qualifications <see cref="Junior"/>
        /// </summary>
        private int juniorEmployeeCount = 8;

        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        public Company()
        {
            this.GetCompanyEmployeesList = new List<Junior>();
            this.FillingOutList(this.leadEmployeeCount, typeof(Lead));
            this.FillingOutList(this.seniorEmployeeCount, typeof(Senior));
            this.FillingOutList(this.middleEmployeeCount, typeof(Middle));
            this.FillingOutList(this.juniorEmployeeCount, typeof(Junior));
        }

        public int GetNumberOfEmployees
        {
            get
            {
                return this.NumberOfEmployees;
            }
        }

        /// <summary>
        /// Gets the company employees list.
        /// </summary>
        public List<Junior> GetCompanyEmployeesList { get; private set; }

        private void FillingOutList(int criteria,Type type)
        {
            for (int i = 0; i < criteria; i++)
            {
                this.GetCompanyEmployeesList.Add(this.GetInstance<Junior>(type.ToString()));
                NumberOfEmployees++;
            }

        }

        private T GetInstance<T>(string type)
        {
            object[] args = { "Company", " Employee" + NumberOfEmployees };
            return (T)Activator.CreateInstance(Type.GetType(type), args);
        }
    }
}