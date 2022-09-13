using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello world!");
            var sWhatITyped = Console.ReadLine();
            Console.WriteLine(sWhatITyped);
            Console.ReadLine();

            /*
            // ask for the users name
            Console.WriteLine("Good morning devine creature, what's your name!");
            var sName = Console.ReadLine();

            // ask for the users age
            Console.WriteLine("And may i ask, how old are you sir/madam ?");
            var sAge = Console.ReadLine();

            Console.WriteLine("Welcome " + sName + " you are " + sAge + " years of age!");
            Console.ReadLine();
            */
        }
    }
}
