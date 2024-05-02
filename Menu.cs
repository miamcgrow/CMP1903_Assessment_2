using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

static void Main()
bool playing = true;
while (playing == true)
{
    Console.WriteLine('Die Game Menu');
    Console.WriteLine('1 - Sevens Out');
    Console.WriteLine('2 - Three Or More');
    Console.WriteLine('3 - View Statistics');
    Console.WriteLine('4 - Perform Tests');
    Console.WriteLine('5 - Exit');
    Console.Write('Input option: ');
    string option = Console.ReadLine();
    switch (option)
    {
        case '1':
            // code block
            break;
        case '2':
            // code block
            break;
        case '3':
            // code block
            break;
        case '4':
            ///
            break;
        case '5':
            bool playing = false
            break;
        case default:
            Console.Writeline('Invalid option')
            break;
    }
}
    ///Game game = new Game(); /// Creates a new game object
    ///game.dice_Display(); /// Calls the display dice method
    ///Testing test = new Testing(); /// Creates a new test object
    ///test.test_Game(); /// Calls the test game method
    ///////test.test_Die(); /// Calls the test die method 