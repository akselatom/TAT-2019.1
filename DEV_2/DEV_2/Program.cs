using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            var test = new RussianPhoneticDictionary();
            Console.WriteLine(test.ProcessingVowelsIntoSounds(inputString));
            Console.WriteLine(test.VoicingOrStunningConsonants(inputString));
        }
    }
}
