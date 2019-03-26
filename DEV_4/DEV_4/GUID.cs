
namespace DEV_4
{
    /// <summary>
    /// Globally Unique Identifier
    /// </summary>
    public class GUID
    {
        /// <summary>
        /// Number of <see cref="GUID"/> objects. Required to generate default ID
        /// </summary>
        private static int callsNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="GUID"/> class.
        /// </summary>
        public GUID()
        {
            this.GenerateUniqueID();
            this.GenerateDescription();
            callsNumber++;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GUID"/> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier 
        /// </param>
        /// <param name="description">
        /// The description.
        /// </param>
        public GUID(string id, string description = "no description")
        {
            this.GenerateUniqueID(id);
            this.GenerateDescription(description);
            callsNumber++;
        }

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
            const int MaxStringSize = 257;
            this.UniqueID = id.Length < MaxStringSize ? id + callsNumber : "object " + callsNumber;
        }

        /// <summary>
        /// Description generator
        /// </summary>
        /// <param name="desc">
        /// The description
        /// </param>
        private void GenerateDescription(string desc = "no description")
        {
            const int MaxStringSize = 257;
            this.Description = desc.Length < MaxStringSize ? desc : "no description";
        }
    }
}