using System;

namespace Step5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input string
            bool isNum = true;
            do
            {
                
                Console.WriteLine("Please enter a number and press ENTER:     ");
                string userString = Console.ReadLine();
                //Ensure string is a set of integers
                {
                    try
                    {
                        int userNum = Convert.ToInt32(userString);
                    }
                    catch (Exception)
                    {
                        isNum = false;
                        Console.WriteLine("That's a nice string of characters, but we're looking for a number.");
                    }
                }

            } while (isNum == false);





            //  { //Index string 
            
            Console.WriteLine("         ");
            Console.WriteLine("______________________________");
            Console.WriteLine("         ");

                   
                       
            //Display string in reverse
          // for (int i = index; i >= 0; i--)
            {
            //  Console.WriteLine("       " + userString[i]);
              //  string[] outString = userString[i index];
            }
            Console.WriteLine("         ");
            Console.WriteLine("______________________________");
            Console.WriteLine("         ");
            //Display on a single line :|
            //Console.WriteLine(outString); }           

        }
    }
}
