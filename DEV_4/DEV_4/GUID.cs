
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
        private static int callsNumber = 0;

        /// <summary>
        /// The unique id.
        /// </summary>
        private string uniqueID;

        /// <summary>
        /// The description.
        /// </summary>
        private string description;

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
        /// Unique index generator
        /// </summary>
        /// <param name="id">
        /// The unique id.
        /// </param>
        private void GenerateUniqueID(string id = "object")
        {
            const int MaxStringSize = 257;
            this.uniqueID = id.Length < MaxStringSize ? id + callsNumber : "object " + callsNumber;
        }

        /// <summary>
        /// Description generator
        /// </summary>
        /// <param name="desc">
        /// The escription
        /// </param>
        private void GenerateDescription(string desc = "no description")
        {
            const int MaxStringSize = 257;
            this.description = desc.Length < MaxStringSize ? desc : "no description";
        }
    }
}