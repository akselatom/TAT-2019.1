
namespace DEV_4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// The materials.
    /// </summary>
    public abstract class Materials
    {
        /// <summary>
        /// <see cref="GUID"/>
        /// </summary>
        private readonly GUID id;

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

        /// <summary>
        /// The equals.
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
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

        public override int GetHashCode()
        {
            return this.id != null ? this.id.GetHashCode() : 0;
        }
    }

    /// <summary>
    /// The lecture.
    /// </summary>
    public class Lecture : Materials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DEV_4.Lecture" /> class.
        /// </summary>
        public Lecture()
        {
            this.LectureText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            this.Materials = new PresentationMaterial();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Lecture"/> class.
        /// </summary>
        /// <param name="lectureText">
        /// The lecture text.
        /// </param>
        /// <param name="material">
        /// The lecture material. Default value is null.
        /// </param>
        public Lecture(string lectureText, PresentationMaterial material = null)
        {
            this.LectureText = lectureText;
            this.Materials = material;
        }

        /// <summary>
        /// Gets field containing lecture text.
        /// </summary>
        public string LectureText { get; private set; }

        /// <summary>
        /// Gets <see cref="PresentationMaterial"/>
        /// </summary>
        public PresentationMaterial Materials { get; private set; }
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

    /// <summary>
    /// The seminar class.
    /// </summary>
    public class Seminar : Materials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Seminar"/> class.
        /// </summary>
        public Seminar()
        {
            this.TaskList = AddDefaultValues();
            this.AnswersList = AddDefaultValues();
            this.QuestionList = AddDefaultValues();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Seminar"/> class.
        /// </summary>
        /// <param name="taskList">
        /// The task list. 
        /// </param>
        /// <param name="answersList">
        /// The answers list.
        /// </param>
        /// <param name="questionList">
        /// The question list.
        /// </param>
        public Seminar(List<string> taskList, List<string> answersList, List<string> questionList)
        {
            this.TaskList = taskList;
            this.AnswersList = answersList;
            this.QuestionList = questionList;
        }

        /// <summary>
        /// Gets the task list.
        /// </summary>
        public List<string> TaskList { get; private set; }

        /// <summary>
        /// Gets the answers list.
        /// </summary>
        public List<string> AnswersList { get; private set; }

        /// <summary>
        /// Gets the question list.
        /// </summary>
        public List<string> QuestionList { get; private set; }

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

    /// <summary>
    /// The laboratory work class.
    /// </summary>
    public class LaboratoryWork : Materials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LaboratoryWork"/> class.
        /// </summary>
        public LaboratoryWork()
        {
            this.TaskList = new List<string> { "default Value" };
            this.Instruction = "Instruction";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LaboratoryWork"/> class.
        /// </summary>
        /// <param name="taskList">
        /// The task list.
        /// </param>
        /// <param name="instruction">
        /// The instruction.
        /// </param>
        public LaboratoryWork(List<string> taskList, string instruction)
        {
            this.TaskList = taskList;
            this.Instruction = instruction;
        }

        /// <summary>
        /// Gets task list.
        /// </summary>
        public List<string> TaskList { get; private set; }

        /// <summary>
        /// Gets the instruction to laboratory work.
        /// </summary>
        public string Instruction { get; private set; }
    }
}