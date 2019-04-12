namespace DEV_3
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    /// <summary>
    /// The company that provides services to the customer, contains a list of employees
    /// </summary>
    public class Company
    {
        /// <summary>
        /// The number of employees.
        /// </summary>
        public int NumberOfEmployees;

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
            this.CompanyEmployeesList = new List<Junior>();
            this.FillingOutList(this.leadEmployeeCount, typeof(Lead));
            this.FillingOutList(this.seniorEmployeeCount, typeof(Senior));
            this.FillingOutList(this.middleEmployeeCount, typeof(Middle));
            this.FillingOutList(this.juniorEmployeeCount, typeof(Junior));
        }

        /// <summary>
        /// Gets company employees list.
        /// </summary>
        public List<Junior> CompanyEmployeesList { get; private set; }

        /// <summary>
        /// Filling the list with objects.
        /// </summary>
        /// <param name="amount">
        /// Required number of objects
        /// </param>
        /// <param name="type">
        /// Required object type.
        /// </param>
        private void FillingOutList(int amount, Type type)
        {
            for (int i = 0; i < amount; i++)
            {
                this.CompanyEmployeesList.Add(this.GetInstance<Junior>(type.ToString()));
                this.NumberOfEmployees++;
            }
        }

        /// <summary>
        /// creates an instance of an object depending on the specified <see cref="Type"/>
        /// </summary>
        /// <typeparam name="T">Creates a instance with T type</typeparam>
        /// <param name="type">Object <see cref="Type"/> </param>
        /// <returns>Returns object of Employee class</returns>
        private T GetInstance<T>(string type)
        {
            object[] args = { "Company", " Employee" + this.NumberOfEmployees };
            return (T)Activator.CreateInstance(Type.GetType(type), args);
        }
    }
}