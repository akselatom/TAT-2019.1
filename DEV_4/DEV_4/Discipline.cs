
namespace DEV_4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The discipline.
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// <see cref="Guid"/>
        /// </summary>
        private readonly Guid id;

        /// <summary>
        /// Initializes a new instance of the <see cref="Discipline"/> class.
        /// </summary>
        public Discipline()
        {
            this.id = new Guid();
            this.DisciplineList = new List<Tuple<Lecture, Seminar, LaboratoryWork>>();
        }

        /// <summary>
        /// Gets discipline list.
        /// </summary>
        public List<Tuple<Lecture, Seminar, LaboratoryWork>> DisciplineList { get; private set; }

        /// <summary>
        /// method that finds by index lecture in <see cref="DisciplineList"/> and related seminars and laboratory works
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <returns>
        /// The <see cref="Tuple"/>.
        /// </returns>
        public Tuple<Lecture, Seminar, LaboratoryWork> this[int index]
        {
            get
            {
                return this.DisciplineList[index];
            }

            set
            {
                this.DisciplineList.Add(value);
            }
        }

        /// <summary>
        /// Add materials to list.
        /// </summary>
        /// <param name="lessonTuple">
        /// The lesson tuple.
        /// </param>
        public void AddMaterialsToDiscipline(Tuple<Lecture, Seminar, LaboratoryWork> lessonTuple)
        {
            this.DisciplineList.Add(lessonTuple);
        }

        /// <inheritdoc />
        /// <summary>
        /// Returns a value indicating whether this object id is equal to a specified <see cref="Discipline"/> object
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        /// <returns>
        /// Returns true if id of both is equal.
        /// </returns>
        public override bool Equals(object obj)
        {
            var m = obj as Discipline; // returns null if object cannot be converted to Discipline
            if (m == null)
            {
                return false;
            }

            return m.id.UniqueID == this.id.UniqueID && m.id.Description == this.id.Description; 
        }

        /// <inheritdoc />
        /// <summary>
        /// The get hash code.
        /// </summary>
        /// <returns>
        /// Returns <see cref="id"/> hash code. 
        /// </returns>
        public override int GetHashCode()
        {
            return this.id != null ? this.id.GetHashCode() : 0;
        }

        /// <summary>
        /// Text description of the entity.
        /// </summary>
        /// <returns>
        /// Return a text description of the entity.
        /// </returns>
        public override string ToString()
        {
            return base.ToString() + ": " + this.id;
        }
    }
}