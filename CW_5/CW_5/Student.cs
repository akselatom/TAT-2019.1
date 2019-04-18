
namespace CW_5
{
    using System.Text;

    /// <summary>
    /// The student.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="firstName">
        /// The first name.
        /// </param>
        /// <param name="secondName">
        /// The second name.
        /// </param>
        /// <param name="speciality">
        /// The speciality.
        /// </param>
        /// <param name="averageMark">
        /// The average mark.
        /// </param>
        public Student(string firstName, string secondName, string speciality, double averageMark)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.AverageMark = averageMark;
            this.Speciality = speciality;
        }

        /// <summary>
        /// Gets student first name.
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// Gets student second name.
        /// </summary>
        public string SecondName { get; private set; }

        /// <summary>
        /// Gets student speciality.
        /// </summary>
        public string Speciality { get; private set; }

        /// <summary>
        /// Gets student average mark.
        /// </summary>
        public double AverageMark { get; private set; }

        /// <summary>
        /// Get info.
        /// </summary>
        /// <returns>
        /// Return all <see cref="Student"/> fields
        /// </returns>
        public string GetInfo()
        {
            var returnString = new StringBuilder();
            returnString.AppendFormat(
                "{0} {1} {2} {3}",
                this.FirstName,
                this.SecondName,
                this.Speciality,
                this.AverageMark);
            return returnString.ToString();
        }
    }
}