﻿
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
            this.fileFormat = FileFormatsList.Txt.ToString();
        }

        /// <summary>
        /// The file formats list.
        /// </summary>
        private enum FileFormatsList
        {
            Unknown,
            Ppt,
            Pdf,
            Txt,
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
            this.fileFormat = Enum.GetNames(typeof(FileFormatsList)).Contains(fileFormat) ? fileFormat : FileFormatsList.Unknown.ToString();
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