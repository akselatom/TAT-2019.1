
namespace CW_4
{
    using System;

    /// <summary>
    /// Data structure development
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            var newList = new MyList<int>(new Node<int>(0));
            var anotherList = new MyList<int>(new Node<int>(10));
            newList.ElementAdded += ShowMassage;
            newList.AddedInAnotherList += anotherList.CheckIsExist;
            newList.Add(20);
            newList.Add(10);
        }

        /// <summary>
        /// Show massage method
        /// </summary>
        /// <param name="message">
        /// The massage.
        /// </param>
        public static void ShowMassage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
