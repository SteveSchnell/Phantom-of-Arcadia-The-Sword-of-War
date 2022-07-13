///-----------------------------------------------------------------
///   Namespace:      RPG
///   Class:          CharacterStatistics
///   Description:    This class calculates and displays the statistics, and numbers from the user character
///   Author:         Steve Schnell                    Date: 5/2/2016
///-----------------------------------------------------------------

using System;
using System.Threading;
using System.Windows.Forms;

/* -- public -----------------------------------------------------------------
** constructor
** Charactersistics()
**
** Description:Constructor of the class
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** void
** CSCalculateRaceGender(string RaceM, string genderM)
**
** Description:Calculates the stats using race and gender
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** void
** CSCalculateClass(string ClassM)
**
** Description:Calculates the stats using class
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** void
** CSCalculateLvUp(int attributes, int Lv, int Exp, string NameM, string ClassM, string RaceM, string genderM,int A)
**
** Description:Calculates the increase in stats when leveling up
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** void
** CSCalculatePrint(int Lv, int Exp, string NameM, string ClassM, string RaceM, string genderM, int Health, int SpellPoints)
**
** Description:Displays the current user stats
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** void
** ClearKeyBuffer()
**
** Description:Clears the key buffer to prevent wrong inputs
** -------------------------------------------------------------------------*/

namespace RPG
{
    class CharacterStatistics
    {
        int HealthMax,
                SpellPointsMax,
                HealthPerLv,
                SpellPointsMultiplier,
                Strength,
                Intelligence,
                Wisdom,
                Agility,
                Charisma,
                Luck,
                CriticalStrike,
                CriticalStrikePerLv;

        string Class,
                Race,
                gender,
                Name;

        public CharacterStatistics()//
        {
            Strength = 15;
            Intelligence = 15;
            Wisdom = 15;
            Agility = 15;
            Charisma = 15;
            Luck = 15;
            HealthMax = 55;
            SpellPointsMax = Intelligence;
        }

        public void CSCalculateRaceGender(string RaceM, string genderM)//
        {
            Race = RaceM;
            gender = genderM;

            if (gender.CompareTo("Male") == 0)//
            {
                if (Race.CompareTo("Dark elf") == 0)
                {
                    Strength += 10;
                    Intelligence += 10;
                    Wisdom -= 10;
                    Agility += 10;
                }
                if (Race.CompareTo("Dwarf") == 0)
                {
                    Strength += 10;
                    Intelligence -= 10;
                    Wisdom -= 10;
                    Agility -= 10;
                }
                if (Race.CompareTo("Elf") == 0)
                {
                    Strength -= 10;
                    Intelligence += 10;
                    Wisdom += 10;
                }
                if (Race.CompareTo("Gnome") == 0)
                {
                    Agility += 10;
                    Luck -= 10;
                }
                if (Race.CompareTo("Half-Elf") == 0)
                {
                    Strength -= 10;
                    Intelligence += 10;
                    Wisdom += 10;
                }
                if (Race.CompareTo("Half-Orc") == 0)
                {
                    Intelligence -= 10;
                    Wisdom -= 10;

                }
                if (Race.CompareTo("Human") == 0)
                {
                    Strength += 10;
                    Luck += 10;
                    Wisdom -= 10;
                }
                if (Race.CompareTo("Orc") == 0)
                {
                    Strength += 10;
                    Intelligence -= 10;
                    Wisdom -= 10;
                    Agility += 10;
                }
                if (Race.CompareTo("Wood elf") == 0)
                {
                    Agility += 10;
                    Luck -= 10;
                }
            }
            if (gender.CompareTo("Female") == 0)//
            {
                if (Race.CompareTo("Dark elf") == 0)
                {
                    Intelligence += 10;
                    Wisdom -= 10;
                }
                if (Race.CompareTo("Dwarf") == 0)
                {
                    Intelligence -= 10;
                    Luck += 10;
                }
                if (Race.CompareTo("Elf") == 0)
                {
                    Strength -= 10;
                    Intelligence += 10;
                    Charisma += 10;
                }
                if (Race.CompareTo("Gnome") == 0)
                {
                    Agility += 10;
                    Luck -= 10;
                }
                if (Race.CompareTo("Half-Elf") == 0)
                {
                    Strength -= 10;
                    Intelligence += 10;
                    Wisdom += 10;
                }
                if (Race.CompareTo("Half-Orc") == 0)
                {
                    Intelligence -= 10;
                    Wisdom -= 10;
                    Agility += 10;
                }
                if (Race.CompareTo("Human") == 0)
                {
                    Charisma += 10;
                    Luck += 10;
                    Wisdom -= 10;
                }
                if (Race.CompareTo("Orc") == 0)
                {
                    Intelligence -= 10;
                    Wisdom -= 10;
                    Agility += 10;
                }
                if (Race.CompareTo("Wood elf") == 0)
                {
                    Agility += 10;
                    Luck -= 10;
                }
            }
        }

        public void CSCalculateClass(string ClassM)//
        {
            Class = ClassM;

            if (Class.CompareTo("Barbarian") == 0)
            {
                SpellPointsMultiplier = 1;
                HealthPerLv = 15;
                CriticalStrike = 0;
                CriticalStrikePerLv = 0;
            }
            if (Class.CompareTo("Bard") == 0)
            {
                SpellPointsMultiplier = 1;
                HealthPerLv = 5;
                CriticalStrike = 0;
                CriticalStrikePerLv = 1;
            }
            if (Class.CompareTo("Knight") == 0)
            {
                SpellPointsMultiplier = 1;
                HealthPerLv = 9;
                CriticalStrike = 0;
                CriticalStrikePerLv = 0;
            }
            if (Class.CompareTo("Battle Mage") == 0)
            {
                SpellPointsMultiplier = 3;
                HealthPerLv = 5;
                CriticalStrike = 0;
                CriticalStrikePerLv = 0;
            }
            if (Class.CompareTo("Warrior") == 0)
            {
                SpellPointsMultiplier = 1;
                HealthPerLv = 10;
                CriticalStrike = 0;
                CriticalStrikePerLv = 0;
            }
            if (Class.CompareTo("Assassins") == 0)
            {
                SpellPointsMultiplier = 1;
                HealthPerLv = 4;
                CriticalStrike = 0;
                CriticalStrikePerLv = 3;
            }
            if (Class.CompareTo("Ranger") == 0)
            {
                SpellPointsMultiplier = 1;
                HealthPerLv = 9;
                CriticalStrike = 0;
                CriticalStrikePerLv = 0;
            }
            if (Class.CompareTo("Thief") == 0)
            {
                SpellPointsMultiplier = 1;
                HealthPerLv = 7;
                CriticalStrike = 0;
                CriticalStrikePerLv = 2;
            }
            if (Class.CompareTo("Spellswords") == 0)
            {
                SpellPointsMultiplier = 2;
                HealthPerLv = 6;
                CriticalStrike = 0;
                CriticalStrikePerLv = 0;
            }
            
        }

        public void CSCalculateLvUp(int attributes, int Lv, int Exp, string NameM, string ClassM, string RaceM, string genderM,int A)//
        {
            ConsoleKeyInfo cki;
            Name = NameM;
            Class = ClassM;
            Race = RaceM;
            gender = genderM;

            HealthMax += HealthPerLv;
            CriticalStrike += CriticalStrikePerLv;

            Thread.Sleep(500);

            while (attributes != 0)//
            {
                Console.Clear();
                int x = 0;

                if(A == 1)
                    Console.Write("\n\n                   You leveled up!");


                SpellPointsMax = (Intelligence * SpellPointsMultiplier);//
               
                Console.Write("\n\n\n         Choose which attribute to increase...    points left: " + attributes + "\n");
                Console.Write("\n         press 1 to increase Strength by one.");
                Console.Write("\n         press 2 to increase Intelligence by one.");
                Console.Write("\n         press 3 to increase Wisdom by one.");
                Console.Write("\n         press 4 to increase Agility by one.");
                Console.Write("\n         press 5 to increase Charisma by one.");
                Console.Write("\n         press 6 to increase Luck by one.");
                Console.Write("\n\n     Class:" + Class + "     Race:" + Race + "     Name:"+Name);
                Console.Write("\n     Str:" + Strength + "     CriticalStrike:" + CriticalStrike + "%");
                Console.Write("\n     Int:" + Intelligence + "     Health:" + HealthMax);
                Console.Write("\n     Wil:" + Wisdom + "     SpellPoints:" + SpellPointsMax);
                Console.Write("\n     Agi:" + Agility + "     Level:" + Lv);
                Console.Write("\n     Cha:" + Charisma + "     Experence:" + Exp);
                Console.Write("\n     Luc:" + Luck);

                while (x != 1)//
                {
                    ClearKeyBuffer();
                    cki = Console.ReadKey(true);

                    if (cki.Key == ConsoleKey.D1)
                    {
                        Strength += 1;
                        x = 1;
                        attributes -= 1;
                    }
                    if (cki.Key == ConsoleKey.D2)
                    {
                        Intelligence += 1;
                        x = 1;
                        attributes -= 1;
                    }
                    if (cki.Key == ConsoleKey.D3)
                    {
                        Wisdom += 1;
                        x = 1;
                        attributes -= 1;
                    }
                    if (cki.Key == ConsoleKey.D4)
                    {
                        Agility += 1;
                        x = 1;
                        attributes -= 1;
                    }
                    if (cki.Key == ConsoleKey.D5)
                    {
                        Charisma += 1;
                        x = 1;
                        attributes -= 1;
                    }
                    if (cki.Key == ConsoleKey.D6)
                    {
                        Luck += 1;
                        x = 1;
                        attributes -= 1;
                    }
                }
            }

            Console.Clear();
            Console.Write("\n\n\n          Attributes distribution complete!");
            Thread.Sleep(1000);

        }

        public void CSCalculatePrint(int Lv, int Exp, string NameM, string ClassM, string RaceM, string genderM, int Health, int SpellPoints)//
        {
            Name = NameM;
            Class = ClassM;
            Race = RaceM;
            gender = genderM;
            string print = "";

            //
            print += "\n\n     Class:" + Class + "     Race:" + Race + "     Name:" + Name;
            print += "\n     Str:" + Strength + "     CriticalStrike:" + CriticalStrike + "%";
            print += "\n     Int:" + Intelligence + "     Health:" + Health  + "/" + HealthMax;
            print += "\n     Wis:" + Wisdom + "     SpellPoints:" + SpellPoints + "/" + SpellPointsMax;
            print += "\n     Agi:" + Agility + "     Level:" + Lv + "     Next Lv: " + (Lv * (Lv * 75)) + " Exp";
            print += "\n     Cha:" + Charisma + "     Experence:" + Exp;
            print += "\n     Luc:" + Luck;

            MessageBox.Show(print, "Phantom of Arcadia: The Sword of War", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        public void ClearKeyBuffer()//
        {
            while (Console.KeyAvailable)
                Console.ReadKey(false);
        }

        public int ReturnHealthMax
        {
            get
            {
                return HealthMax;
            }
            set
            {
                HealthMax = value;
            }
        }
        public int ReturnSpellPointsMax
        {
            get
            {
                return SpellPointsMax;
            }
            set
            {
                SpellPointsMax = value;
            }
        }
        public int ReturnHealthPerLv
        {
            get
            {
                return HealthPerLv;
            }
            set
            {
                HealthPerLv = value;
            }
        }
        public int ReturnSpellPointsMultiplier
        {
            get
            {
                return SpellPointsMultiplier;
            }
            set
            {
                SpellPointsMultiplier = value;
            }
        }
        public int ReturnStrength
        {
            get
            {
                return Strength;
            }
            set
            {
                Strength = value;
            }
        }
        public int ReturnIntelligence
        {
            get
            {
                return Intelligence;
            }
            set
            {
                Intelligence = value;
            }
        }
        public int ReturnWisdom
        {
            get
            {
                return Wisdom;
            }
            set
            {
                Wisdom = value;
            }
        }
        public int ReturnAgility
        {
            get
            {
                return Agility;
            }
            set
            {
                Agility = value;
            }
        }
        public int ReturnCharisma
        {
            get
            {
                return Charisma;
            }
            set
            {
                Charisma = value;
            }
        }
        public int ReturnLuck
        {
            get
            {
                return Luck;
            }
            set
            {
                Luck = value;
            }
        }
        public int ReturnCriticalStrike
        {
            get
            {
                return CriticalStrike;
            }
            set
            {
                CriticalStrike = value;
            }
        }
        public int ReturnCriticalStrikePerLv
        {
            get
            {
                return CriticalStrikePerLv;
            }
            set
            {
                CriticalStrikePerLv = value;
            }
        }
     
    }
}
