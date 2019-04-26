
namespace DEV_4
{
    /// <summary>
    /// Globally Unique Identifier
    /// </summary>
    public class Guid
    {
        /// <summary>
        /// Max Unique Identifier length
        /// </summary>
        private const int MaxStringSize = 257;

        /// <summary>
        /// Initializes a new instance of the <see cref="Guid"/> class.
        /// </summary>
        public Guid()
        {
            this.GenerateUniqueID();
            this.GenerateDescription();
            CallsNumber++;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Guid"/> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier 
        /// </param>
        /// <param name="description">
        /// The description.
        /// </param>
        public Guid(string id, string description = "no description")
        {
            this.GenerateUniqueID(id);
            this.GenerateDescription(description);
            CallsNumber++;
        }

        /// <summary>
        /// Gets number of <see cref="Guid"/> objects. Required to generate default ID
        /// </summary>
        public static int CallsNumber { get; private set; }

        /// <summary>
        /// Gets the unique id.
        /// </summary>
        public string UniqueID { get; private set; }

        /// <summary>
        /// Gets the description.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Text description of the entity.
        /// </summary>
        /// <returns>
        /// Return a text description of the entity.
        /// </returns>
        public override string ToString()
        {
            return this.Description;
        }

        /// <summary>
        /// Unique index generator
        /// </summary>
        /// <param name="id">
        /// The unique id.
        /// </param>
        private void GenerateUniqueID(string id = "object")
        {
            this.UniqueID = id.Length < MaxStringSize ? id + CallsNumber : "object " + CallsNumber;
        }

        /// <summary>
        /// Description generator
        /// </summary>
        /// <param name="desc">
        /// The description
        /// </param>
        private void GenerateDescription(string desc = "no description")
        {
            this.Description = desc.Length < MaxStringSize ? desc : "no description";
        }
    }
}