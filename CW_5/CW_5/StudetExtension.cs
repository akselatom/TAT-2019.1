
namespace CW_5
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The <see cref="Student"/> extension.
    /// </summary>
    public static class StudentExtension
    {
        /// <summary>
        /// The filter.
        /// </summary>
        /// <param name="students">
        /// The student collection
        /// </param>
        /// <param name="predicate">
        /// The predicate.
        /// </param>
        /// <returns>
        /// Return collection which satisfies predicate
        /// </returns>
        public static IEnumerable<Student> Filter(this IEnumerable<Student> students, Func<Student, bool> predicate)
        {
            foreach (var student in students)
            {
                if (predicate(student))
                {
                    yield return student;
                }
            }
        }
    }
}
