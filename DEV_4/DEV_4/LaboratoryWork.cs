
namespace DEV_4
{
    using System.Collections.Generic;

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