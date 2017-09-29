using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first name?");
            String firstName = Console.ReadLine();
            firstName = firstName.ToUpper();

            //testing the case changing
            //Console.WriteLine(firstName);

            Console.WriteLine("What is your last name?");
            String lastName = Console.ReadLine();
            lastName = lastName.ToUpper();

            Console.WriteLine("What is your age?");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("What month were you born in (format: 01-12");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorive ROYGBIV color? \n (If you're unsure what ROYGBIV is, type Help)");
            String tempColorInput = Console.ReadLine();
            tempColorInput = tempColorInput.ToUpper();
            String favoriteColor;
            if (tempColorInput == "HELP")
            {
                Console.WriteLine("ROYGBIV is Red Blue Yellow Green Blue Indigo Violet");
                favoriteColor = Console.ReadLine();
            }
            else
            {
                favoriteColor = tempColorInput.ToUpper();
            }

            Console.WriteLine("How many siblings do you have?");
            int numSiblings = int.Parse(Console.ReadLine());

            //checking inputs
            Console.WriteLine(firstName + " " + lastName + " " + userAge + " " + birthMonth + " " + favoriteColor + " " + numSiblings);





        }
    }
}
