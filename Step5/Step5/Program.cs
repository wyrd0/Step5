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
            //Get user input into an array
            Console.WriteLine("Please enter a number and press ENTER:     ");
            string userString = Console.ReadLine();
            Console.WriteLine(userString);

            //Try to index string
            int sLength = userString.Length;
            Console.WriteLine("sLength =" + sLength);
            foreach (int tempVar in userString)
            {
                Console.WriteLine(tempVar);
            }
            //Ensure string is a set of integers
            int[] userNum = new int[userString.Length];
            //Console.WriteLine(new[]);
            //Manipulate data type, if necessary
            //Display input array in reverse0
        }
    }
}
