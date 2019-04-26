
namespace DEV_4
{
    using System.Collections.Generic;

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
}