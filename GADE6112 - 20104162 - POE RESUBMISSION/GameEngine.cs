using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static GADE5112___20104162___Task_1.Character;

namespace GADE5112___20104162___Task_1
{
    internal class GameEngine
    {
        //Create the GameEngine class.

        protected Map localMap;
        private const string fileName = "Map.binary";

        //Give the GameEngine class a Shop object. 

        //Shop shopObj = new Shop();

        public GameEngine(Map map)
        {
            this.map = map;
        }

        public Map map
        {
            get
            {
                return localMap;
            }
            set
            {
                localMap = value;
            }
        }

        public bool MovePlayer(Character.Movement direction)
        {
            int x, y, tempx, tempy;
            x = this.localMap.hero.X;
            y = this.localMap.hero.Y;

            Character.Movement selectedMove = direction;
            switch (selectedMove)
            {
                case Movement.NoMovement:
                    selectedMove = Movement.NoMovement;
                    break;

                case Movement.Up:
                    x = 0;
                    y = -1;
                    break;

                case Movement.Down:
                    x = 0;
                    y = 1;
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

            // Check for valid move

            if (localMap.MapGrab[localMap.hero.X + x, localMap.hero.Y + y] is EmptyTile || localMap.GetItemAtPosition(localMap.hero.X + x, localMap.hero.Y + y) is Gold)
            {
                // Valid

                localMap.hero.Move(selectedMove);
                localMap.UpdateMap();
                localMap.MapGrab[localMap.hero.X - x, localMap.hero.Y - y] = new EmptyTile(localMap.hero.X - x, localMap.hero.Y - y);
                return true;

            }
            else { return false; }
        }

        public override string ToString()
        {
            return null;
        }

        public void EnemyAttacks()
        {
        }

        public void MoveEnemies()
        {
        }

        public void Save()
        {
            FileStream outputFile = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(outputFile, localMap);
            outputFile.Close();
        }

        public void Load()
        {
            FileStream inputFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Map fromFile = (Map)binaryFormatter.Deserialize(inputFile);
            inputFile.Close();
        }
    }
}