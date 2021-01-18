using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GADE5112___20104162___Task_1.Character;

namespace GADE5112___20104162___Task_1
{
    class Shop
    {
        //Qu 2.5 : Create the Shop class.
        //      •	A Weapon array of size 3 for the 3 random Weapons that appear in the shop 
        //      •	A Random object to randomise numbers 
        //      •	A Character object to denote the buyer(who to deduct gold from when buying)

        private Weapon[] weaponTypeArray = new Weapon[4];
        private Random random = new Random();
        private Character buyer;



        public Shop(Character buyer) 
        {
            // A constructor that receives a Character parameter to set as the buyer, initialises the Weapon array and the Random object.
            // Loops through the Weapon array, placing a random weapon in each slot through the RandomWeapon() method.

            for (int i = 0; i < 4; i++)
            {
                weaponTypeArray[i] = RandomWeapon();
            }
        }

        private Weapon RandomWeapon()
        {
            //Randomises and returns either a Dagger, Longsword, Longbow or Rifle object. 

            int position = random.Next(4);
            MeleeWeapon dagger = new MeleeWeapon(position, position, 'D', MeleeWeapon.Types.Dagger);
            MeleeWeapon longsword = new MeleeWeapon(position, position, 'S', MeleeWeapon.Types.Longsword);
            RangedWeapon rifle = new RangedWeapon(position, position, 'R', RangedWeapon.Types.Rifle);
            RangedWeapon longbow = new RangedWeapon(position, position, 'B', RangedWeapon.Types.Longbow);

            switch (position)
            {
                case 0:
                    return dagger;
                    break;
                case 1:
                    return longsword;
                    break;
                case 2:
                    return rifle;
                    break;
                case 3:
                    return longbow;
                    break;
                default:
                    return null;
            }
        }

        
    

        public bool CanBuy(int num)
        {
            //Returns true if the buyer can afford the item in the given slot of the Weapon array based on the buyer’s gold and the weapon’s cost. 

            if (buyer.goldPurse > weaponTypeArray[num].costAccessor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Buy(int num)
        {
            // Decrements the buyer’s gold by the cost of the weapon they purchase, has them pickup the weapon through their PickUp() method.
            // Randomises a new weapon in the bought item slot for the shop.

            buyer.goldPurse -= weaponTypeArray[num].costAccessor;
            //PickUp();
            RandomWeapon();

        }

        public string DisplayWeapon(int num)
        {
            //Returns a string – “Buy WeaponType (X Gold)” that is assigned to the Form button to describe what is in the shop and how much it costs. 

            return $"Buy {weaponTypeArray[num].weaponTypeAccessor} ({weaponTypeArray[num].costAccessor} Gold)";
        }

    }
}
