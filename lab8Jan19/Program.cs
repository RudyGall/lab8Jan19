using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8Jan19
{
    class Program
    {
        class Info
        {
            public static void StudentInfo(string userInputString)
            {
                int userInput = int.Parse(userInputString) - 1;
                string[,] studentInfo = new string[15, 3]
                {
                {"Kent","Lansing","Apples" },
                {"Justin","Ann Arbor","Fries" },
                {"Brian","Kalamazoo","Cereal" },
                {"Noha","Southfield","Salmon" },
                {"Ronald","Pontiac","Chips" },
                {"Steve","Bloomfield","Ravioli" },
                {"AK","Ypsilanti","Wheat Thins" },
                {"Evan","Troy","Ham" },
                {"Laura","Grand Haven","Bread" },
                {"Jacky","Detroit, MI","Sushi" },
                {"Kendra","Belleville","Stir-fry" },
                {"Levi","Detroit","Steak" },
                {"Mauricio","Warren","Ice Cream" },
                {"Rudy","Canton","Cheese" },
                {"Steve","Toledo","Pizza" },
                };
                Console.WriteLine(studentInfo[userInput, 0]);
                Console.WriteLine("Would you like to know their favorite food or their hometown?");
                for (int j = 0; j == 0;)
                {
                    string pickInfo = Console.ReadLine().ToLower();
                    if (pickInfo == "hometown")
                    {
                        Console.WriteLine(studentInfo[userInput, 1]);
                        j++;
                    }
                    else if (pickInfo == "favorite food")
                    {
                        Console.WriteLine(studentInfo[userInput, 2]);
                        j++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry, please type out hometown or favorite food");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            bool runP = true;
            while (runP == true)
            { 
                    Console.WriteLine("Please enter a student number between 1 and 15");
                    string userInputString = Console.ReadLine();
                    try
                    {
                        Info.StudentInfo(userInputString);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Index is out of range exception");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Incorrect format exception");
                    }
                    runP = Continue();
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("\nWould you like to learn information about another student? (Y or N)");
            string input = Console.ReadLine().ToLower();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                Console.WriteLine("Thank you, Goodbye!");
                Console.ReadLine();
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }
            return goOn;
        }
    }
}