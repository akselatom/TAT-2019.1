
namespace DEV_4
{
    using System;
    using System.Linq;
    using System.Text;

    /// <inheritdoc />
    /// <summary>
    /// The presentation material.
    /// </summary>
    public class PresentationMaterial : Materials
    {
        /// <summary>
        /// The file formats list.
        /// </summary>
        private static readonly string[] FileFormatsList = { "unknown", "ppt", "pdf", "txt" };

        /// <summary>
        /// The uri.
        /// </summary>
        private string uri;

        /// <summary>
        /// The file format.
        /// </summary>
        private string fileFormat;

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DEV_4.PresentationMaterial" /> class.
        /// </summary>
        public PresentationMaterial()
        {
            this.uri = AppDomain.CurrentDomain.BaseDirectory + "\\PresentationMaterial\\lectureText";
            this.fileFormat = FileFormatsList[3];
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DEV_4.PresentationMaterial" /> class.
        /// </summary>
        /// <param name="filePath">
        /// The file path.
        /// </param>
        /// <param name="fileFormat">
        /// The file format. <see cref="FileFormatsList"/>
        /// </param>
        public PresentationMaterial(string filePath, string fileFormat = "txt")
        {
            this.uri = filePath;
            this.fileFormat = FileFormatsList.Contains(fileFormat) ? fileFormat : FileFormatsList[0];
        }

        /// <summary>
        /// The presentation material file path.
        /// </summary>
        /// <returns>
        /// Returns string with file path
        /// </returns>
        public string PresentationMaterialFilePath()
        {
            StringBuilder outputString = new StringBuilder();
            outputString.AppendLine(this.uri);
            outputString.AppendLine(this.fileFormat);
            return outputString.ToString();
        }
    }
}