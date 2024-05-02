using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace CMP1903M_Assessment_2
{
    internal class Testing
    {
        int testsum = 0;
        private void Test_Seven()
        {
            SevensOut game = new SevensOut(); // Creates game object
            testsum  = game.Playing(); // Cals the sum method 
            Debug.Assert(testsum >= 2 && testsum <= 12, "Invalid total sum"); // Tests if total die sum is valid
            /// Test if game ends at total of 7
        }
        public void Test_Three()
        {
            // Tests that scores set and added correctly.
            // Tests whether a total >= 20 is recognised and game ends.
        }
    }
}