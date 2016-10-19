using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input string
            Console.WriteLine("Please enter a number and press ENTER:     ");
            string userString = Console.ReadLine();
            
            //Ensure string is a set of integers

            //Index string 
            int sLength = userString.Length;
            int index = sLength - 1;
            Console.WriteLine("         ");
            Console.WriteLine("______________________________");
            Console.WriteLine("         ");
            //Display string in reverse
            for (int i = index; i >= 0; i--)
            {
               Console.WriteLine("       " + userString[i]);
              //  string[] outString = userString[i index];
            }
            Console.WriteLine("         ");
            Console.WriteLine("______________________________");
            Console.WriteLine("         ");
            //Display on a single line :|
            //Console.WriteLine(outString);            

        }
    }
}
