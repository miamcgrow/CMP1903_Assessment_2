using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_2
{
    public class Die
    {
        private static Random random = new Random(); // Random object to generate random integers
        public int die_Value { get; set; } // Public property to hold the current die value
        public int Roll() // Public method to roll the die and generate a random value
        {
            die_Value = random.Next(1, 7); // Assigns a randomly generated number between 1-6 
            return die_Value; // Returns the current die value
        }
    }
}