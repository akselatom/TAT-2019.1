namespace DEV_6
{
    using System;

    public class CommandInvoker
    {
        private IConsoleCommand command;

        private AutoDatabase data;

        public CommandInvoker(string xmlPath)
        {
            this.data = new AutoDatabase(xmlPath);
        }

        public void ProvideUserInterface()
        {
            Console.WriteLine("Input Command: ");
            switch (Console.ReadLine())
            {

            }
                
        }
    }
}