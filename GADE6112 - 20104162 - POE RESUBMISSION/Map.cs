using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20104162___Task_1
{
    [Serializable]
    class Map
    {
        //This is my Map class that contains : 
        //      A 2D Tile array to represent the map.
        //      A Hero object to represent the player character.
        //      An Enemy array for the enemies.
        //      Variables for storing the map’s width and height.
        //      A Random object for randomising numbers.

        protected Tile[,] mapArray;
        protected Enemy[] numEnemies;

        //You must create a new Item array that stores items that exist on the map.

        protected Item[] itemArray;
        protected Hero newHero;
        protected int mapWidth;
        protected int mapHeight;
        protected Random random = new Random();

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numberEnemies, int gold, int weaponDrop)
        {
            //A constructor that receives a minimum and maximum width, minimum and maximum height and number of enemies.

            //You should also tweak your Map constructor to take an additional parameter: 
            //      the amount of gold drops on the map, which is then used as your initial size for your items array.

            mapWidth = random.Next(minWidth, maxWidth);
            mapHeight = random.Next(minHeight, maxHeight);

            mapArray = new Tile[mapWidth, mapHeight];
            for (int y = 0; y < mapHeight; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    if (y == 0 || y == mapHeight - 1)
                    {
                        mapArray[x, y] = new Obstacle(x, y);
                    }
                    else
                    {
                        if (x == 0 || x == mapWidth - 1)
                        {
                            mapArray[x, y] = new Obstacle(x, y);
                        }
                        else
                        {
                            mapArray[x, y] = new EmptyTile(x, y);
                        }
                    }
                }
            }

            numEnemies = new Enemy[(mapWidth + mapHeight) / 3];

            for (int i = 0; i < numEnemies.Count(); i++)
            {
                numEnemies[i] = (Enemy)Create(Tile.TileType.Enemy);
            }

            itemArray = new Weapon[(mapWidth + mapHeight) / 3];

            for (int i = 0; i < itemArray.Count(); i++)
            {
                //itemArray[i] = (Gold)Create(Tile.TileType.Gold);
                itemArray[i] = (Weapon)Create(Tile.TileType.Weapon);
            }

            UpdateVision();
            newHero = (Hero)Create(type: Tile.TileType.Hero);
        }


        // Property Methods
        public Tile[,] MapGrab
        {
            get
            {
                return mapArray;
            }

        }
        public int MapHeightGrab
        {
            get
            {
                return mapHeight;
            }
        }
        public int MapWidthGrab
        {
            get
            {
                return mapWidth;
            }
        }
        public Hero hero
        {
            get
            {
                return newHero;
            }

        }

        public void UpdateMap()
        {
            foreach (Tile thing in mapArray)
            {
                mapArray[thing.X, thing.Y] = thing;
            }
        }

        public void UpdateVision()
        {
            //Updates the vision array for each Character.

            Tile[,] tempTile;
            tempTile = new Tile[mapWidth, mapHeight];

            foreach (Enemy temp in numEnemies)
            {
                for (int i = -1; i < 2; i++)
                {
                    if (i + temp.X >= mapWidth - 1 || i + temp.X < 0) { continue; }
                    for (int k = -1; k < 2; k++)
                    {
                        if (k + temp.Y >= mapHeight - 1 || k + temp.Y < 0) { continue; }
                        tempTile[temp.X + i, temp.Y + k] = mapArray[temp.X + i, temp.Y + k];
                        temp.characterVision = tempTile;
                    }
                }
            }

            foreach (Weapon temp in itemArray)
            {
                for (int i = -1; i < 2; i++)
                {
                    if (i + temp.X >= mapWidth - 1 || i + temp.X < 0) { continue; }
                    for (int k = -1; k < 2; k++)
                    {
                        if (k + temp.Y >= mapHeight - 1 || k + temp.Y < 0) { continue; }
                        tempTile[temp.X + i, temp.Y + k] = mapArray[temp.X + i, temp.Y + k];
                        temp.characterVision = tempTile;
                    }
                }
            }
        }

        private Tile Create(Tile.TileType type)
        {
            //This method is used to create objects and also place them on the map.

            random = new Random();
            Tile tempTile = null;
            int randomX = random.Next(1, mapWidth - 1);
            int randomY = random.Next(1, mapHeight - 1);
            int gold = random.Next(1, 6);
            int heroHP = 0;
            char heroSymbol = 'H';
            char goldSymbol = 'G';
            while ((mapArray[randomX, randomY] is EmptyTile) == false)
            {
                randomX = random.Next(1, mapWidth);
                randomY = random.Next(1, mapHeight);
            }

            switch (type)
            {
                case Tile.TileType.Hero:
                    tempTile = new Hero(randomX, randomY, heroHP, heroSymbol);
                    break;
                case Tile.TileType.Enemy:

                    //Integrate the Gold and Mage classes into your existing GameEngine and Map classes.

                    //Your Enemy array in map should now randomize between Goblins, Mages and Leaders.

                    int typeEnemy = random.Next(3);

                    if (typeEnemy <= 0)
                    {
                        tempTile = new Goblin(randomX, randomY);
                    }
                    else if (typeEnemy <= 1)
                    {
                        tempTile = new Mage(randomX, randomY);
                    }
                    else if (typeEnemy <= 2)
                    {
                        tempTile = new Leader(randomX, randomY);
                    }
                    break;

                case Tile.TileType.Gold:
                    tempTile = new Gold(randomX, randomY, goldSymbol);
                    break;

                case Tile.TileType.Weapon:

                    int typeWeapon = random.Next(4);

                    if (typeWeapon <= 0)
                    {
                        tempTile = new MeleeWeapon(randomX, randomY, 'D', MeleeWeapon.Types.Dagger);
                    }
                    else if (typeWeapon <= 1)
                    {
                        tempTile = new MeleeWeapon(randomX, randomY, 'S', MeleeWeapon.Types.Longsword);
                    }
                    else if (typeWeapon <= 2)
                    {
                        tempTile = new RangedWeapon(randomX, randomY, 'R', RangedWeapon.Types.Rifle);
                    }
                    else if (typeWeapon <= 3)
                    {
                        tempTile = new RangedWeapon(randomX, randomY, 'B', RangedWeapon.Types.Longbow);
                    }
                    break;

                default:
                    break;
            }
            mapArray[randomX, randomY] = tempTile;
            return tempTile;
        }

        public Item GetItemAtPosition(int x, int y)
        {
            try
            {
                return (Item)mapArray[x, y];
            }
            catch (InvalidCastException e)
            {
                // Not handling this
            }
            return null;
        }
    }
}
