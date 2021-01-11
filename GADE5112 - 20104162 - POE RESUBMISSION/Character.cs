using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20104162___Task_1
{
    abstract class Character : Tile
    {
        //This abstract base class is called Character and it inherits from Tile.
        //This is the true base class for your Hero and Goblin classes.

        protected Tile[,] characterVisionArray;
        public int characterHP
        { get; set; }
        protected int characterMaxHP
        { get; set; }
        public int characterDamage
        { get; set; }
        public int goldPurse
        { get; set; }
        public string weaponType
        { get; set; }
        public double weaponDamage
        { get; set; }
        public double weaponDurability
        { get; set; }
        public virtual double weaponRange
        { get; set; }

        public Character(int positionX, int positionY) : base(positionX, positionY)
        {
            //A constructor that receives X and Y positions and a symbol and delegates the setting of those variables to the Tile class via a constructor initializer.
        }

        public Tile[,] characterVision
        {
            get
            {
                return characterVisionArray;
            }
            set
            {
                characterVisionArray = value;
            }
        }

        public enum Movement
        {
            NoMovement = 0,
            Up = 1,
            Down = 2,
            Left = 3,
            Right = 4,
        }

        //The Character class contains the following methods, most of which define generic implementations for all characters to use.

        public virtual void Attack(Character target)
        {
            //Attacks a target and decreases its health by the attacking character’s damage.

            target.characterHP -= characterDamage;
        }

        public bool IsDead()
        {
            //Checks if the character is dead.

            if (characterHP < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool CheckRange(Character target)
        {
            //Checks if a target is in range of a character.

            int distanceToTarget = DistanceTo(target);

            // Change 1 when weapons implemented.

            if (distanceToTarget <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int DistanceTo(Character target)
        {
            //Determines the absolute distance.
            int distanceX, distanceY, tempx, tempy;
            distanceX = 0;
            distanceY = 0;
            bool posorneg;
            if (target.X > X) { posorneg = true; } else { posorneg = false; }
            tempx = X;
            while (tempx != target.X)
            {
                if (posorneg)
                {
                    tempx++;
                    distanceX++;
                }
                else
                {
                    tempx--;
                    distanceX++;
                }
            }
            if (target.Y > Y) { posorneg = true; } else { posorneg = false; }
            tempy = Y;
            while (tempy != target.Y)
            {
                if (posorneg)
                {
                    tempy++;
                    distanceY++;
                }
                else
                {
                    tempy--;
                    distanceY++;
                }
            }
            return distanceX + distanceY;
        }

        public void Move(Movement move)
        {
            //The Move method edits a unit’s X and Y values to move it up / down / left / right based on the identifier from the enum.
            //Edited Character's Move() method to cater for a move parameter that denotes no movement.
            switch (move)
            {
                case Movement.Up:
                    Y -= 1;
                    break;

                case Movement.Down:
                    Y += 1;
                    break;

                case Movement.Left:
                    X -= 1;
                    break;

                case Movement.Right:
                    X += 1;
                    break;

                case Movement.NoMovement:
                    X = 0;
                    Y = 0;
                    break;

                default:
                    X = X;
                    Y = Y;
                    break;
            }
        }

        public void Pickup(Item i)
        {
            //Qu 3.2 : Edit your Character and Map and GameEngine classes to allow Items to be picked up by Characters.

            switch (i)
            {
                case Gold gold:
                    gold = (Gold)i;
                    goldPurse += gold.gold_Drop;
                    break;
                default:
                    break;
            }
        }

        public abstract Movement ReturnMove(Movement move = 0);

        public abstract override string ToString();
    }
}
