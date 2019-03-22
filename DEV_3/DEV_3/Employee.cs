﻿namespace DEV_3
{
    using System.Text;

    /// <summary>
    /// The employee.
    /// </summary>
    public abstract class Employee
    {
        /// <summary>
        /// The first name.
        /// </summary>
        private readonly string firstName;

        /// <summary>
        /// The second name.
        /// </summary>
        private readonly string secondName;

  
        protected Employee()
        {
            this.firstName = "name";
            this.secondName = "secondName";
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="firstName">
        /// The first name.
        /// </param>
        /// <param name="secondName">
        /// The second name.
        /// </param>
        protected Employee(string firstName = "test", string secondName = "test")
        {
            this.firstName = firstName;
            this.secondName = secondName;
          
        }

        /// <summary>
        /// Gets a employee full name.
        /// </summary>
        public string GetName
        {
            get
            {
                return this.firstName +" "+ this.secondName;
            }
        }

        /// <summary>
        /// All <see cref="Employee"/> field information
        /// </summary>
        /// <returns>Format string with <see cref="Employee"/> information</returns>
        public virtual string GetInfo()
        {
            StringBuilder outputString = new StringBuilder();
            outputString.AppendFormat(this.GetName);
            outputString.Append(" ");
            outputString.AppendFormat(this.GetType().ToString().Substring(this.GetType().ToString().LastIndexOf('.')));
            return outputString.ToString();
        }
    }

    /// <summary>
    /// The junior. 
    /// </summary>
    public class Junior : Employee
    {
        /// <summary>
        /// The salary.
        /// </summary>
        protected int salary;

        /// <summary>
        /// The productivity.
        /// </summary>
        protected int productivity;

        /// <summary>
        /// Initializes a new instance of the <see cref="Junior"/> class.
        /// </summary>
        public Junior()
        {
            this.salary = 50;
            this.productivity = 15;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Junior"/> class.
        /// </summary>
        /// <param name="firstName">
        /// The first name.
        /// </param>
        /// <param name="secondName">
        /// The second name.
        /// </param>
        public Junior(string firstName = "test", string secondName = "test")
            : base(firstName, secondName)
        {
            this.salary = 50;
            this.productivity = 15;
        }

        /// <summary>
        /// Gets the salary.
        /// </summary>
        public int GetSalary
        {
            get
            {
                return this.salary;
            }
        }

        /// <summary>
        /// Gets the efficiency coefficient.
        /// </summary>
        public double GetEfficiencyCoefficient
        {
            get
            {
                return this.productivity / (double)this.salary;
            }
        }

        /// <summary>
        /// Gets the productivity.
        /// </summary>
        public int GetProductivity
        {
            get
            {
                return this.productivity;
            }
        }

        /// <summary>
        /// All <see cref="Junior"/> field information
        /// </summary>
        /// <returns>Format string with <see cref="Junior"/> information</returns>
        public override string GetInfo()
        {
            StringBuilder outputString = new StringBuilder();
            outputString.AppendFormat(this.GetName);
            outputString.Append(" ");
            outputString.AppendFormat(this.GetType().ToString().Substring(this.GetType().ToString().LastIndexOf('.')));
            outputString.AppendFormat(" Productivity:{0} , Salary:{1}", this.GetProductivity, this.GetSalary);
            return outputString.ToString();
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// The middle.
    /// </summary>
    public class Middle : Junior
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Middle"/> class.
        /// </summary>
        public Middle()
        {
            this.salary = 75;
            this.productivity = 20;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Middle"/> class.
        /// </summary>
        /// <param name="firstName">
        /// The first name.
        /// </param>
        /// <param name="secondName">
        /// The second name.
        /// </param>
        public Middle(string firstName = "test", string secondName = "test")
            : base(firstName, secondName)
        {
            this.salary = 75;
            this.productivity = 20;
        }
    }

    /// <summary>
    /// The senior.
    /// </summary>
    public class Senior : Middle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Senior"/> class.
        /// </summary>
        public Senior()
        {
            this.salary = 100;
            this.productivity = 30;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Senior"/> class.
        /// </summary>
        /// <param name="firstName">
        /// The first name.
        /// </param>
        /// <param name="secondName">
        /// The second name.
        /// </param>
        public Senior(string firstName = "test", string secondName = "test")
            : base(firstName, secondName)
        {
            this.salary = 100;
            this.productivity = 30;
        }
    }

    /// <summary>
    /// The team lead.
    /// </summary>
    public class Lead : Senior
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Lead"/> class.
        /// </summary>
        public Lead()
        {
            this.salary = 180;
            this.productivity = 50;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Lead"/> class.
        /// </summary>
        /// <param name="firstName">
        /// The first name.
        /// </param>
        /// <param name="secondName">
        /// The second name.
        /// </param>
        public Lead(string firstName = "test", string secondName = "test")
            : base(firstName, secondName)
        {
            this.salary = 180;
            this.productivity = 50;
        }   
    }
}