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
    internal class ThreeOrMore
    {
        int player1_score = 0; // Instance of player 1 score 
        int player2_score = 0; // Instance of player 2 score 
        private int matches; // Instance of matches 
        private int dice; // Instance of dice 
        int[] all_matches; // Instance of all matches 
        int[] dicerolls; // Instance of dice rolls 
        bool players_turn = true; // Assign boolean to true 

        public object roll1 { get; set; } // Get and set all the roll objects
        public object roll2 { get; set; }
        public object roll3 { get; set; }
        public object roll4 { get; set; }
        public object roll5 { get; set; }

        public void Dice_Roll()
        {
            Die die1 = new Die(); // Create dice object
            Die die2 = new Die(); // Create dice object
            Die die3 = new Die(); // Create dice object
            Die die4 = new Die(); // Create dice object
            Die die5 = new Die(); // Create dice object
            roll1 = die1.Roll(); 
            roll2 = die2.Roll();
            roll3 = die3.Roll();
            roll4 = die4.Roll();
            roll5 = die5.Roll();
            dicerolls = new int[] { (int)roll1, (int)roll2, (int)roll3, (int)roll4, (int)roll5 };
        }
        public void Display_Roll()
        {
            Console.WriteLine(roll1);
            Console.WriteLine(roll2);
            Console.WriteLine(roll3);
            Console.WriteLine(roll4);
            Console.WriteLine(roll5);
        }

        /*
        public void Calculate_Points(int dice)
        {
            for (int i = 1; i > 7; i++)
            {
                all_matches[i] = 0;
                matches = 0;
                foreach (int dice in dicerolls)
                    if dice == i { matches = matches + 1}
                all_matches[i] = matches;
            }

            /// If 2-of-a-kind is rolled, player may choose to rethrow all, or the remaining dice.
            /// 3-of-a-kind: 3 points 
            ///  4-of-a-kind: 6 point   
            ///  5-of-a-kind: 12 point
            ///  First to a total of 20. 
         */

        public void Print_Scores()
        {
            Console.WriteLine('Player 1 Score:', player1_score);
            Console.WriteLine('Player 2 Score:', player2_score);
        }

        public void Play(object v)
        {
            bool playing = true;
            while (playing == true)
            {
            }
        } 
    }
}

