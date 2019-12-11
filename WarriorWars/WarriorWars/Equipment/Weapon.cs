using WarriorWars.Enum;


namespace WarriorWars.Equipment
{
    class Weapon
    {
        /*This sets the damage that each person does at a base level, it cannot be
          changed or accessed using these names.*/

        private const int GOOD_GUY_DAMAGE = 5;
        private const int BAD_GUY_DAMAGE = 5;
        private int damage;

        /*Takes the above assigned values and creates Damage, which is used for the base damage calculations.*/ 
        
        public int Damage
        {
            get
            {
                return damage;
            }
        }


        // Assigns the damage value based on faction
        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:

                    damage = GOOD_GUY_DAMAGE;

                    break;

                case Faction.BadGuy:

                    damage = BAD_GUY_DAMAGE;
                    
                    break;
                default:
                    break;

            }


        }


        }
    } 
