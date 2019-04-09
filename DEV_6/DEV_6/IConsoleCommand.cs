namespace DEV_6
{
    /// <summary>
    /// Interface for defining console commands
    /// </summary>
    public interface IConsoleCommand
    {
        /// <summary>
        /// The execute method
        /// </summary>
        /// <param name="data">
        /// Database <see cref="AutoDatabase"/>
        /// </param>
        void Execute(AutoDatabase data);
    }
}