using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
                        
                //The following section of code retrieves the needed information from the user, declares a data type, assigns a variable, 
                //and initializes with the user's response (maniuplating the response when necessary). Heavy use of the escape \n just 
                //helps to make sure the console is readable.

                Console.WriteLine("Hello and Welcome to the Fortune Teller.\nI will tell you your fortune after I ask just a few simple questions.\nLet's begin.\n\nWhat is your first name?");
                string firstName = Console.ReadLine();
                     
                Console.WriteLine("\nHello " + firstName + "! Please tell me your last name.");
                string lastName = Console.ReadLine();

                Console.WriteLine("\nHow old are you in whole years?\nFor example, if you are thirty-four years old, type 34.");
                int userAge = int.Parse(Console.ReadLine());

                Console.WriteLine("\nPlease enter the number 1-12 that corresponds to your birth month, leaving out any leading zeros.\nFor instance, if your birth month is January, simply type 1.\nBut if you were born in October, you would type 10.");
                int birthMonth = int.Parse(Console.ReadLine());

                Console.WriteLine("\nWhat is your favorite ROYGBIV color? \nIf you don't know ROYGBIV type help.");
                string favColor = Console.ReadLine().ToLower();

                while (favColor == "help")//in the event the user doesn't know ROYGBIV, this while loop will give them the necessary explanation
                {
                    Console.WriteLine("\nThe ROYGBIV colors are:\nR = Red \nO = Orange \nY = yellow \nG = Green \nB = Blue \nI = Indigo \nV = Violet.\n\nWhat is your favorite ROYGBIV color?\n");
                    favColor = Console.ReadLine().ToLower();
                }

                Console.WriteLine("\nWe're almost there, {0}! Just one last question.\nHow many siblings do you have?", firstName);
                int siblings = int.Parse(Console.ReadLine());
                //We have collected all the needed information. The next section of code determines the fortune based on the user input. 


                //Determines when the user will retire (string timeToRetirement) based on whether their age (int userAge) is even or odd:
                string timeToRetirement = "";

                if (userAge % 2 == 0)
                {
                    timeToRetirement = "14 years";
                }
                else
                {
                    timeToRetirement = "31 years";
                }

                //Determines where the user will retire (string retirementHome) based on how many siblings (int siblings) they have:
                string retirementHome = "";

                if (siblings > 3)
                {
                    siblings = 4; //this manipulation will allow me to use a switch case and still use the default to account for a negative number.
                }

                switch (siblings)
                {

                    case 0:
                        retirementHome = "Cleveland, OH";
                        break;

                    case 1:
                        retirementHome = "Orlando, FL";
                        break;

                    case 2:
                        retirementHome = "Venezuela";
                        break;

                    case 3:
                        retirementHome = "Australia";
                        break;

                    case 4:
                        retirementHome = "A cabin in the woods of Vermont";
                        break;

                    default:
                        retirementHome = "Post zombie apocolyptic Trump Tower";
                        break;//This default is meant to "tease" the user for entering a negative number. 
                }

                //Determines user's mode of transportation (string userTransport) based on their favorite color (string favColor)
                //this will be done using sequential if else if else to allow for the user to input either the full name of the color or
                //the first letter of the color and assign the mode of transportation at the same time. 
                
                string userTransport = "";
            
                if (favColor == "r" || favColor == "red")
                {
                    userTransport = "a red Ferrari";
                }
                else if (favColor == "o" || favColor == "orange")
                {
                    userTransport = "an orange hot air ballon";
                }
                else if (favColor == "y" || favColor == "yellow")
                {
                    userTransport = "a yellow mustang";
                }
                else if (favColor == "g" || favColor == "green")
                {
                    userTransport = "an electric scooter";
                }
                else if (favColor == "b" || favColor == "blue")
                {
                    userTransport = "a blue angel jet";
                }
                else if (favColor == "i" || favColor == "indigo")
                {
                    userTransport = "a teleporter";
                }
                else if (favColor == "v" || favColor == "violet")
                {
                    userTransport = "a violet hoverboard from \"Back to the Future\"";
                }
                else
                {
                    userTransport = "a hover-round wheelchair";
                }

                //Determines the how much money (double bankAccount) the user will have in their account based on their birth month (int birthMonth) 
                double bankAccount = 0;

                if (birthMonth >= 1 && birthMonth <= 4)
                {
                    bankAccount = 12340.22;
                }
                else if (birthMonth >= 5 && birthMonth <= 8)
                {
                    bankAccount = 200000.75;
                }
                else if (birthMonth >= 9 && birthMonth <= 12)
                {
                    bankAccount = 145678.88;
                }
                else
                    bankAccount = 0.00;

                // This final section of code writes our "fortune" to the Console:
                Console.WriteLine("\n\nI have your fortune {0} {1}.\n\nYou will retire in {2} years with ${3} in the bank and a vacation home in {4}.\nYou will use {5} to get around.", firstName, lastName, timeToRetirement, bankAccount, retirementHome, userTransport);
            
 
        }
    }
}
