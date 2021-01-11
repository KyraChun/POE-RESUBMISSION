using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20104162___Task_1
{
    abstract class Enemy : Character
    {
        //The abstract Enemy class which inherits from Character.

        protected Random random = new Random();

        public Enemy(int enemyHP, int enemyDamage, int positionX, int positionY, char symbol = 'E') : base(positionX, positionY)
        {
            //Enemy constructor that receives X and Y positions, an enemy’s damage and it is starting HP(and thus also max HP) and its symbol.
            //It delegates its X and Y position to the Character subclass via a constructor initialiser.
            //It then sets all the relevant member variables.

            characterHP = enemyHP;
            characterDamage = enemyDamage;
            characterMaxHP = characterHP;
        }

        public override string ToString()
        {
            //An overridden ToString method that, using the enemy’s class, outputs a string that looks as follows:  
            //     EnemyClassName at[X, Y] (Amount DMG)

            //You will also need to edit your Player Stats and Enemy Stats ToString() to include weapon damage, range etc.
            //Barehanded: Mage(5 / 5HP) at[6, 6](5 DMG)
            //Equipped: Leader(20 / 20HP) at[6, 1] with Longsword(DURABILITYxAMOUNT DMG)

            return $"Enemy Class: {weaponType}: { this.GetType().FullName } ({characterHP}  at [  { X } , { Y } ] (  {characterDamage} DMG)";
        }
    }


    class Leader : Enemy
    {
        //Qu 2.4 : Create the Leader class, a subclass of Enemy.

        public Leader(int positionX, int positionY) : base(20, 2, positionX, positionY, 'L')
        {
            //A constructor that receives only an X and Y position, but delegates its  variable setting mostly to the Enemy class along the following parameters: 
            //          o Leaders have 20 HP
            //          o Leaders do 2 damage

            //It then sets all the relevant member variables.
        }

        private Tile leaderTarget
        {
            get
            {
                return leaderTarget;
            }
            set
            {
                leaderTarget = value;
            }
        }

        public Movement getRandomMove()
        {
            Movement selectedMove = Movement.NoMovement;
            Array values = Enum.GetValues(typeof(Movement));
            Random random = new Random();
            selectedMove = (Movement)values.GetValue(random.Next(values.Length));
            return selectedMove;
        }

        public override Movement ReturnMove(Movement move = 0)
        {
            Movement selectedMove = getRandomMove();
            int x, y;
            x = 0;
            y = 0;
            switch (selectedMove)
            {
                case Movement.NoMovement:
                    selectedMove = Movement.NoMovement;
                    break;
                case Movement.Up:
                    x = 0;
                    y = 1;
                    break;
                case Movement.Down:
                    x = 0;
                    y = -1;
                    break;
                case Movement.Left:
                    x = -1;
                    y = 0;
                    break;
                case Movement.Right:
                    x = 1;
                    y = 0;
                    break;
                default:
                    selectedMove = Movement.NoMovement;
                    break;
            }

            while (base.characterVision[x, y] != null)
            {
                selectedMove = getRandomMove();
                switch (selectedMove)
                {
                    case Movement.NoMovement:
                        selectedMove = Movement.NoMovement;
                        break;
                    case Movement.Up:
                        x = 0;
                        y = 1;
                        break;
                    case Movement.Down:
                        x = 0;
                        y = -1;
                        break;
                    case Movement.Left:
                        x = -1;
                        y = 0;
                        break;
                    case Movement.Right:
                        x = 1;
                        y = 0;
                        break;
                    default:
                        selectedMove = Movement.NoMovement;
                        break;
                }
            }

            return selectedMove;
        }    
    }
}
