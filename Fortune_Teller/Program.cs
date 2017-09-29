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
            //Console.WriteLine(firstName + " " + lastName + " " + userAge + " " + birthMonth + " " + favoriteColor + " " + numSiblings);


            int yearsTillRetire;
            if (userAge % 2 == 0)
            {
                yearsTillRetire = 32;
            }
            else
            {
                yearsTillRetire = 40;
            }

            String vacationHome;
            if (numSiblings >= 0)
            {
                switch (numSiblings)
                {
                    case 0:
                        vacationHome = "Cologn Germany";
                        break;

                    case 1:
                        vacationHome = "Key West Florida";
                        break;

                    case 2:
                        vacationHome = "South carolina";
                        break;

                    case 3:
                        vacationHome = "Atlanta Georgia";
                        break;

                    default:
                        vacationHome = "Cleveland Ohio";
                        break;

                }
            }
            else
            {
                vacationHome = "Detroit Michigan";
            }

            String modeOfTransport;
            switch (favoriteColor)
            {
                case "RED":
                    modeOfTransport = "Zaku II HMT";
                    break;

                case "ORANGE":
                    modeOfTransport = "Cevy Camaro";
                    break;

                case "YELLOW":
                    modeOfTransport = "Ford Mustang";
                    break;

                case "GREEN":
                    modeOfTransport = "Toyota Prius";
                    break;

                case "BLUE":
                    modeOfTransport = "Subaru Impretza WRX STI";
                    break;

                case "INDIGO":
                    modeOfTransport = "Toyota GT86";
                    break;

                case "VIOLET":
                    modeOfTransport = "Dodge Challanger";
                    break;

                default:
                    modeOfTransport = "SmartCar";
                    break;
            }

            double moneySaved;
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                moneySaved = 44000;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                moneySaved = 63000;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                moneySaved = 97000;
            }
            else
            {
                moneySaved = 0;
            }

            //testing part 2 functions
            //Console.WriteLine(yearsTillRetire + " " + vacationHome + " " + modeOfTransport + " " + moneySaved);


            Console.WriteLine("{0} {1} will retire in {2} years with ${3} in the bank, a vaction home in {4}, and a {5}.",
                firstName, lastName, yearsTillRetire, moneySaved, vacationHome, modeOfTransport);


        }
    }
}
