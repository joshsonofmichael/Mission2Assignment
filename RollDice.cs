using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    internal class RollDice
    {
        // Create a new instance of the Random class
        Random random = new Random();
        private int OneRoll()
        {
            

            // Generate a random number between 1 and 6 (inclusive)
            int diceRoll = random.Next(1, 7);
            
            return diceRoll;
        }
        public int[] Roll(int numRolls)
        {
            int[] combinations = new int[11];

            for (int i = 0; i < numRolls; i++)
            {
                int dice1 = OneRoll();
                int dice2 = OneRoll();
                int combination = dice1 + dice2;

                combinations[(combination - 2)]++;
            }

            return combinations;
        }
    }
}
