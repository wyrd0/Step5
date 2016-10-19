using System;

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

            { try
                {
                    int userNum = Convert.ToInt32(userString);
                    Console.WriteLine(userNum);
                }
                catch(Exception)
                {
                    Console.WriteLine("That's a nice string of characters.  Please enter a number:    ");
                }
                }

            
            
            
            
            
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
