using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE5112___20104162___Task_1
{
    public partial class GameForm : Form
    {
        private Map localmap;
        private int border;
        private GameEngine gameEng;
        private Random random = new Random();

        public GameForm()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture Up arrow key

            if (keyData == Keys.Up)
            {
                if (gameEng.MovePlayer(Character.Movement.Up) == false) { };
                updateMap();
                return true;
            }

            //capture Down arrow key

            if (keyData == Keys.Down)
            {
                if (gameEng.MovePlayer(Character.Movement.Down) == false) { };
                updateMap();
                return true;
            }

            //capture Left arrow key

            if (keyData == Keys.Left)
            {
                if (gameEng.MovePlayer(Character.Movement.Left) == false) { };
                updateMap();
                return true;
            }

            //capture Right arrow key

            if (keyData == Keys.Right)
            {
                if (gameEng.MovePlayer(Character.Movement.Right) == false) { };
                updateMap();
                return true;
            }

            if (keyData == Keys.Space)
            {
                attack_BTN.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void heroName_LB_Click(object sender, EventArgs e)
        {            
        }

        private void heroAttack_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
        }

        private void attack_BTN_Click(object sender, EventArgs e)
        {
        }

        private void map_LB_Click(object sender, EventArgs e)
        {
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            //Used to randomise the size of the map, number of enemies, gold drop and weapon drop

            int minWidth = random.Next(1, 11);
            int maxWidth = random.Next(11, 21);
            int minHeight = random.Next(1, 11);
            int maxHeight = random.Next(11, 21);
            int enemies = random.Next(8);
            int gold = random.Next(1, 6);
            int weapons = random.Next(6);

            heroName_LB.Text = Convert.ToString(heroName_TB.Text);
            localmap = new Map(minWidth, maxWidth, minHeight, maxHeight, enemies, gold, weapons);
            gameEng = new GameEngine(localmap);
            border = gameEng.map.MapWidthGrab - 1;
            updateMap();

        }

        private void updateMap()
        {
            map.Clear();
            string newLine;
            heroStats_LB.Text = gameEng.map.hero.ToString();

            // This updates the map every time we move 
            for (int y = 0; y < gameEng.map.MapHeightGrab; y++)
            {
                if (y != 0) { map.Text += "\n"; };
                for (int x = 0; x < gameEng.map.MapWidthGrab; x++)
                {
                    switch (gameEng.map.MapGrab[x, y])
                    {
                        case EmptyTile _:
                            map.Text += "_";
                            break;
                        case Obstacle _:
                            map.Text += "X";
                            break;
                        case Hero _:
                            map.Text += "H";
                            break;
                        case Gold _:
                            map.Text += "G";
                            break;
                        case Goblin _:
                            map.Text += "K";
                            break;
                        case Mage _:
                            map.Text += "M";
                            break;
                        case Leader _:
                            map.Text += "L";
                            break;
                        case Weapon _:
                            map.Text += "W";
                            break;

                    }
                }
            }
        }

        private void heroName_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void shop_btn_Click(object sender, EventArgs e)
        {
            // Assigned to the Form button to describe what is in the shop and how much it costs. 

            //int weapon = random.Next(1, 3);
            //Shop myShop = new Shop();
            //myShop.DisplayWeapon(weapon);
        }
    }
}
