using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class!");
            Boolean run = true;
            while (run == true)
            {

                string[] studentName = new string[] { "Enrico Fermi", "Robert Oppenheimer", "Ice T", "Han Solo", "Hacksaw Jim Duggan", "King Kong", "Superman", "Ivan Drago", "The Gunslinger", "Leonidas" };
                string[] studentHometown = new string[] { "Somewhere in Italy", "Podunk", "Mean Streets of Compton", "Galaxy far, far away", "Parts Unknown", "Skull Island", "Krypton", "Siberia", "Gilead", "Lakedaemon" };
                string[] studentFoods = new string[] { "Momma's Lasagna", "Something smarmy and not very filling", "Dunkin Donuts", "Grilled tauntaun", "Roadkill Stew", "Anything he wants", "Apple Pie", "Borscht", "Tuna Fish Sandwich", "Not Persian" };
                Console.WriteLine("Which student would you like to learn more about? (1-10)");
                int selectedNumber;
                bool valid = int.TryParse(Console.ReadLine(), out selectedNumber);
                if (valid == false)
                {
                    Console.WriteLine("That was not a valid input. Please select a student between 1-10.");
                }
                else
                {
                    string chosenOne = Identify(selectedNumber, studentName);
                    string chosenHome = FindHome(selectedNumber, studentHometown);
                    string chosenFood = FindFood(selectedNumber, studentFoods);
                    Console.WriteLine("Student number " + selectedNumber + " is " + chosenOne + ".");
                    Console.WriteLine("Would you like to know more about " + chosenOne + "? Select hometown or favorite food.");
                    string knowMore = Console.ReadLine().ToLower();
                    if (knowMore == "hometown")
                    {
                        Console.WriteLine(chosenOne + "'s hometown is " + chosenHome + ". Would you like to know more about " + chosenOne + "? (y/n)");
                        string knowFood = Console.ReadLine().ToLower();
                        if (knowFood == "y")
                        {
                            Console.WriteLine(chosenOne + "'s favorite food is " + chosenFood + ".");
                        }

                    }
                    else if (knowMore == "favorite food")
                    {
                        Console.WriteLine(chosenOne + "'s favorite food is " + chosenFood + ". Would you like to know more about " + chosenOne + "? (y/n)");
                        string knowHome = Console.ReadLine().ToLower();
                        if (knowHome == "y")
                        {
                            Console.WriteLine(chosenOne + "'s hometown is " + chosenHome + ".");
                        }
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid input. Please select a student from 1-10.");
                    }
                    Continue();

                }

            }
        }
        public static string Identify(int selectedNumber, string[] studentName)
        {
            string identity = studentName[selectedNumber - 1];
            return identity;
        }
        public static string FindHome(int selectedNumber, string[] studentHometown)
        {
            string home = studentHometown[selectedNumber - 1];
            return home;
        }
        public static string FindFood(int selectedNumber, string[] studentFoods)
        {
            string food = studentFoods[selectedNumber - 1];
            return food;
        }

        public static Boolean Continue()
        {
          Console.WriteLine("Would you like to learn about another student? (Y/N): ");
            string input = Console.ReadLine().ToLower();
            Boolean run = true;
            if (input == "n")
            {
                Console.WriteLine("Thanks for visiting the strangest C# class in history!");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
           {
                Console.WriteLine("I'm sorry, I didn't understand your input. Let's try that again!");
                run = Continue();
            }

            return run;
        }
    }
}
