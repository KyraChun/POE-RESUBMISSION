using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE5112___20104162___Task_1
{
    class Goblin : Enemy
    {
        //Concrete Goblin class which inherits from Enemy.
        public Goblin(int positionY, int positionX) : base(10, 1, positionY, positionX, 'G')
        {
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