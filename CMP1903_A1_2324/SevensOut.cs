using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CMP1903M_Assessment_2
{
    internal class SevensOut
    {
        Die die1 = new Die(); // Create a new dice object
        Die die2 = new Die(); // Create a new dice object
        int roll1 = 0; // Instance of roll 
        int roll2 = 0; // Instance of roll 
        int total = 0; // Instance of total 
        int score = 0; // Instance of score  
        bool seven_Found = false; // Assign false boolean

        public int Sum() // Calculates the total roll
        {
            total = roll1 + roll2;
            return total;
        }
        public int Playing()
        {
            while (seven_Found == false) // While loop until a 7 total is found
            {
                roll1 = die1.Roll(); // Randomly rolls die 1
                roll2 = die2.Roll(); // Randomly rolls die 2
                total = Sum();
                score = score + total; // Adds total to the game score
                Console.WriteLine("Die 1:", roll1); // Prints the die 1 roll
                Console.WriteLine("Die 2:", roll2); // Prints the die 2 roll
                Console.WriteLine("Total:", total); // Prints the total roll 
                if (total == 7) // If the total roll is a 7
                {
                    seven_Found = true; // Assigns true boolean and ends the while loop
                    Console.WriteLine("Seven total found!");
                    Console.WriteLine("Game Total:", score); // Prints the overall game score
                }
                else if (roll1 == roll2) // If a double is rolled
                {
                    score = score + total; // Then another total is added to overall score, doubling it
                }
            }
        }
    }
}
   
