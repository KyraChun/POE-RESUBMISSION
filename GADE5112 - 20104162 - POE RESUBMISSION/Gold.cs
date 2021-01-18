using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20104162___Task_1
{
    class Gold : Item
    {
        //This is the concrete class Gold which inherits from Item.

        private int amountOfGold;

        //A private member variable for the amount of gold represented by a gold drop and a public accessor that can return that amount.

        public int gold_Drop
        {
            get
            {
                return amountOfGold;
            }
            set
            {
                amountOfGold = value;
            }
        }

        //A private Random object to randomize gold amounts.

        Random rnd = new Random();

        public Gold(int positionX, int positionY) : base(positionX, positionY, 'G')
        {
            //A constructor that receives an X and Y position. It delegates the X and Y position to the Item constructor via a constructor initialiser. 
            //It then sets the amount to a random amount between 1 and 5 (inclusive).

            amountOfGold = rnd.Next(1, 6);
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
