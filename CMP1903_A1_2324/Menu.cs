using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_2
{
    public class Main()
    {
        bool playing = true; // Assign boolean true
        while (playing == true) // Loop while boolean is true
        {
            Console.WriteLine('Die Game Menu'); // Displays menu 
            Console.WriteLine('1 - Sevens Out');
            Console.WriteLine('2 - Three Or More');
            Console.WriteLine('3 - View Statistics');
            Console.WriteLine('4 - Perform Tests');
            Console.WriteLine('5 - Exit');
            Console.Write('Input option: '); // User inputs option
            string option = Console.ReadLine(); // Input is assigned to variable
            switch (option) 
            {
                case '1': // If 1 was inputted
                    SevensOut game = new SevensOut(); // Creates a Sevensout object
                    game.Playing() // Calls the Playing method
                    break;
                case '2': // If 2 was inputted
                    ThreeOrMore game = new ThreeOrMore(); // Creates a ThreeorMore object
                    // ThreeOrMore.Play()
                    break;
                case '3': // If 3 was inputted
                    // code block
                    break;
                case '4': // If 4 was inputted
                    /// 
                    break;
                case '5': // If 5 was inputted
                    bool playing = false // Assigns false boolean and ends while loop
                    break;
                case default: // If input is invalid
                    Console.Writeline('Invalid option, try again')
                    break;
            }
        }
    }
}
