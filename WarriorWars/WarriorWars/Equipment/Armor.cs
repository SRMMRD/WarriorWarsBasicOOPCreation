using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Armor
    {
        /*This sets the armor of the warriors, as a constant it will never change, it also cannot be accessed
        directly using this name. armorPoints is the one that will actually be used in the code to access the
        values of the constants.*/
        
        private const int GOOD_GUY_ARMOR = 5;
        private const int BAD_GUY_ARMOR = 5;
        private int armorPoints;


        /*ArmorPoints is used to get armorPoints, note the casing as they're two different things. armorPoints
          is used to directly access the above constant variables which are private so they need to be accessed in a
          roundabout way. It then takes armorPoints and assigns it the value from the constants and then AGAIN
          creates ArmorPoints (again note casing) which is public and how the constants are actually used in the code.*/

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }

        //This sets the armor based on faction.

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:

                    armorPoints = GOOD_GUY_ARMOR;

                    break;
                case Faction.BadGuy:

                    armorPoints = BAD_GUY_ARMOR;

                    break;
                default:
                    break;
            }
        }

}   }  
