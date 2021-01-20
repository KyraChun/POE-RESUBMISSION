namespace GADE5112___20104162___Task_1
{
    internal class Hero : Character
    {
        //Concrete Hero subclass, which inherits from Character.

        public Hero(int positionX, int positionY, int heroHP, char symbol) : base(positionX, positionY)
        {
            //The Hero constructor receives X and Y position and HP.
            //It should then set the HP and max HP of the hero based on the parameter.
            //Additionally, a Hero’s damage is always 2.

            base.characterDamage = 2;
            base.characterMaxHP = heroHP;            
        }

        public override string ToString()
        {
            //An overridden ToString() method: This returns the formatted Player Stats as shown below:
            //      Player Stats:
            //      HP: HP / Max HP
            //      Damage: 2
            //      [X, Y]

            // You will also need to edit your Player Stats and Enemy Stats ToString() to include weapon damage, range etc. 

            return $"Player Stats: \n HP: {characterHP} / {characterMaxHP} \n Current Weapon: {weaponType} \n Weapon Range: {weaponRange} \n Weapon Damage: {weaponDamage} \n Durability: {weaponDurability} \n Gold: {goldPurse}";
        }

        public override Movement ReturnMove(Movement move)
        {
            int x, y;
            x = 0;
            y = 0;
            Movement selectedMove = move;
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

            if (base.characterVision[x, y] is EmptyTile)
            {
                return selectedMove;
            }
            else
            {
                return Movement.NoMovement;
            }
        }
    }
}