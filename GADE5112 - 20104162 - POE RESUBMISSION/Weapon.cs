using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GADE5112___20104162___Task_1.Character;

namespace GADE5112___20104162___Task_1
{
      //Qu 2.1 : Create the Weapon abstract class that inherits from Item.
      //It contains the following protected member variables and relevant public accessors: 
           //• Damage 
           //• Range(the accessor for this should be virtual to be overridden by the subclasses)
           //• Durability 
           //• Cost 
           //• Weapon Type

      //It also contains a constructor that receives a symbol as well as optional X and Y positions (because a weapon can either be equipped to a Character or exists on the Map). 
      //This data is delegated to the Tile superclass via a constructor initializer.
      //All weapon‐specific data is set in the subclasses.

    abstract class Weapon : Item
    {
        protected int damage;
        public int damageAccessor
        {
            get
            {
                return damage;
            }

            set
            {
                damage = value;
            }
        }

        protected int durability;
        public int durabilityAccessor
        {
            get
            {
                return durability;
            }

            set
            {
                durability = value;
            }
        }

        protected int cost;
        public int costAccessor
        {
            get
            {
                return cost;
            }

            set
            {
                cost = value;
            }
        }

        protected string weaponType;
        public string weaponTypeAccessor
        {
            get
            {
                return weaponType;
            }

            set
            {
                weaponType = value;
            }
        }

        protected int range;
        public virtual int rangeAccessor
        {
            get
            {
                return range;
            }

            set
            {
                range = value;
            }
        }

        public Weapon(int positionX, int positionY, char symbol) : base(positionX, positionY)
        {

        }
    }

    class MeleeWeapon : Weapon
    {
        //Qu 2.2 : Create the MeleeWeapon subclass.
        //           The constructor switches on the type of weapon based on the parameter provided.

        public MeleeWeapon(int positionX, int positionY, char symbol, Types weaponType) : base(positionX, positionY, symbol)
        {
            //A constructor that merely receives an enum variable that defines the type of Weapon to be created

            if (weaponType == Types.Dagger)
            {
                weaponTypeAccessor = "Dagger";
                durabilityAccessor = 10;
                damageAccessor = 3;
                costAccessor = 3;
            }

            if (weaponType == Types.Longsword)
            {
                weaponTypeAccessor = "Longsword";
                durabilityAccessor = 6;
                damageAccessor = 4;
                costAccessor = 5;
            }
        }

        public enum Types
        {
            //A public enum called Types which defines two types of MeleeWeapon.

            Longsword,
            Dagger
        }       

        public override int rangeAccessor
        {
            //A public overridden Range accessor that returns 1 for MeleeWeapons.

            get
            {
                return 1;
            }
            set
            {
                rangeAccessor = value;
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }

    class RangedWeapon : Weapon
    {
        //Qu 2.3 : Create the RangedWeapon class.
        //           The constructor switches on the type of weapon based on the parameter provided.

        public RangedWeapon(int positionX, int positionY, char symbol, Types weaponType) : base(positionX, positionY, symbol)
        {
            //A constructor that merely receives an enum variable that defines the type of Weapon to be created

            if (weaponType == Types.Rifle)
            {
                weaponTypeAccessor = "Rifle";
                durabilityAccessor = 3;
                damageAccessor = 5;
                costAccessor = 7;
                rangeAccessor = 3;
            }

            if (weaponType == Types.Longbow)
            {
                weaponTypeAccessor = "Longbow";
                durabilityAccessor = 4;
                damageAccessor = 4;
                costAccessor = 6;
                rangeAccessor = 2;
            }
        }

        public enum Types
        {
            //A public enum called Types which defines two types of RangedWeapon.

            Rifle,
            Longbow
        }

        public override int rangeAccessor
        {
            //A public overridden Range accessor that returns base.Range.

            get
            {
                return base.rangeAccessor;
            }
            set {  }

        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
