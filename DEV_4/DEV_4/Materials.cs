namespace DEV_4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The materials.
    /// </summary>
    public abstract class Materials
    {
        /// <summary>
        /// <see cref="GUID"/>
        /// </summary>
        private GUID id;

        /// <summary>
        /// Initializes a new instance of the <see cref="Materials"/> class.
        /// </summary>
        protected Materials()
        {
            this.id = new GUID();
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
            this.id = description == null ? new GUID(id) : new GUID(id, description);
        }
    }

    /// <summary>
    /// The lecture.
    /// </summary>
    public class Lecture : Materials
    {
        /// <summary>
        /// field containing lecture text.
        /// </summary>
        private string lectureText;

        /// <summary>
        /// <see cref="PresentationMaterial"/>
        /// </summary>
        private PresentationMaterial materials;

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DEV_4.Lecture" /> class.
        /// </summary>
        public Lecture()
        {
            this.lectureText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            this.materials = new PresentationMaterial();
        }

    }

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
    }

    public class Seminar : Materials
    {
        /// <summary>
        /// The task list.
        /// </summary>
        private List<string> taskList;

        /// <summary>
        /// The answers list.
        /// </summary>
        private List<string> answersList;

        /// <summary>
        /// The question list.
        /// </summary>
        private List<string> questionList;

        /// <summary>
        /// Initializes a new instance of the <see cref="Seminar"/> class.
        /// </summary>
        public Seminar()
        {
            this.taskList = AddDefaultValues();
            this.answersList = AddDefaultValues();
            this.questionList = AddDefaultValues();
        }

        /// <summary>
        /// Add default values.
        /// </summary>
        /// <returns>
        /// Returns <see cref="List{T}"/> with default values
        /// </returns>
        private static List<string> AddDefaultValues()
        {
            var list = new List<string> { "default value" };
            return list;
        }
    }

    public class LaboratoryWork : Materials
    {
        /// <summary>
        /// The task list.
        /// </summary>
        private List<string> taskList;

        /// <summary>
        /// The instruction to laboratory work.
        /// </summary>
        private string instruction;

        /// <summary>
        /// Initializes a new instance of the <see cref="LaboratoryWork"/> class.
        /// </summary>
        public LaboratoryWork()
        {
            this.taskList = new List<string> { "default Value" };
            this.instruction = "Instruction";
        }
    }
}