using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20104162___Task_1
{
    class Mage : Enemy
    {
        //This is the concrete Mage subclass, a new type of Enemy.

        public Mage(int positionX, int positionY) : base(5, 5, positionX, positionY, 'M')
        {
            //A constructor that receives only an X and Y position, but delegates its variable setting mostly to the Enemy class along the following parameters:
            //      o Mages have 5 HP
            //      o Mages do 5 damage
        }

        public virtual int ReturnMove()
        {
            //An overridden ReturnMove() method: 
            //      This method does not use the optional movement parameter.
            //      The method always returns a 0, as Mages never moves. 

            return 0;
        }

        public virtual bool CheckRange(Character target)
        {
            //An overridden CheckRange() method: Mages attack all Characters around them in a one block radius.

            //Left
            if (target.X == X - 1 && target.Y == Y)
            {
                return true;
            }
            //Top Left
            else if (target.X == X - 1 && target.Y == Y - 1)
            {
                return true;
            }
            //Above
            else if (target.X == X && target.Y == Y - 1)
            {
                return true;
            }
            //Top Right
            else if (target.X == X + 1 && target.Y == Y - 1)
            {
                return true;
            }
            //Right
            else if (target.X == X + 1 && target.Y == Y)
            {
                return true;
            }
            //Bottom Right
            else if (target.X == X + 1 && target.Y == Y + 1)
            {
                return true;
            }
            //Below
            else if (target.X == X && target.Y == Y + 1)
            {
                return true;
            }
            //Bottom Left
            else if (target.X == X - 1 && target.Y == Y + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override Movement ReturnMove(Movement move = Movement.NoMovement)
        {
            throw new NotImplementedException();
        }
    }
}
