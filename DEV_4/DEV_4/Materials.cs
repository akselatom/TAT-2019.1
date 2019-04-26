
namespace DEV_4
{
    /// <summary>
    /// The materials.
    /// </summary>
    public abstract class Materials
    {
        /// <summary>
        /// <see cref="Guid"/>
        /// </summary>
        private readonly Guid id;

        /// <summary>
        /// Initializes a new instance of the <see cref="Materials"/> class.
        /// </summary>
        protected Materials()
        {
            this.id = new Guid();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Materials"/> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="description">
        /// The description.
        /// </param>
        protected Materials(string id, string description = null)
        {
            this.id = description == null ? new Guid(id) : new Guid(id, description);
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

        /// <inheritdoc />
        /// <summary>
        /// Returns a value indicating whether this object id is equal to a specified <see cref="Materials"/> object
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        /// <returns>
        /// Returns true if id of both is equal.
        /// </returns>
        public override bool Equals(object obj)
        {         
            var m = obj as Materials; // returns null if object cannot be converted to Materials
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
    }
}