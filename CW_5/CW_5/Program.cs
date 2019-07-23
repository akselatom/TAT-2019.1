
namespace CW_5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The entry method of the program
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>
                           {
                               new Student("Sergey", "Kalykhan", "Rf", 5.9),
                               new Student("Vadim", "Kolos", "Rf", 4.6),
                               new Student("Dima", "Lvov", "Rf", 5.5),
                               new Student("Aleksandr", "Prigoda", "Kb", 6.5),
                               new Student("Vlad", "Rebko", "Rf", 5.8)
                           };

            var selectedStudents = students.OrderByDescending(t => t.AverageMark).Filter(t => t.Speciality == "Rf")
                .Take(3);

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student.GetInfo());
            }   
         }
    }
}
