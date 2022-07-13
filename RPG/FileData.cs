///-----------------------------------------------------------------
///   Namespace:      RPG
///   Class:          FileData
///   Description:    This class saves and loads files containing the stats from the user
///   Author:         Steve Schnell                    Date: 5/2/2016
///-----------------------------------------------------------------

using System;
using System.IO;

/* -- public -----------------------------------------------------------------
** constructor
** FileData()
**
** Description:Constructor from the class
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** bool
** SaveExists()
**
** Description:Checks if there is a saved file present, and returns a bool
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** void
** SaveString(String Name, String Class,String Race,String gender)
**
** Description:This function saves the string variable from the user to a file
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** void
** SaveInt(int HealthMax, int SpellPointsMax, int HealthPerLv, int SpellPointsMultiplier, int Strength, int Intelligence, int Wisdom, int Agility, int Charisma, int Luck, int CriticalStrike, int CriticalStrikePerLv, int Lv, int Health, int SpellPoints, int stage, int Exp)
**
** Description:This function saves a Int variable from the user to the file
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** string[]
** LoadString()
**
** Description:This function loads the string variable from the file, and returns a array of strings
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** string[]
** LoadInt()
**
** Description:This function loads the int variable from the file, and returns a array of strings
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** void
** SaveEncrypt()
**
** Description:Encrypes the file, so only the user who generated the file can access it
** -------------------------------------------------------------------------*/

namespace RPG
{
    class FileData
    {
        private const string FILE_NAME = "Phantom_of_Arcadia_Data_String.txt";//
        private const string FILE_NAME_TWO = "Phantom_of_Arcadia_Data_Int.txt";

        static string User = Environment.UserName;//

        string MyDocPath = "C:\\Users\\" + User + "\\AppData\\Local\\PhantomOfArcadia\\";//
        string MyDocPathFolder = @"C:\\Users\\" + User + "\\AppData\\Local\\PhantomOfArcadia";

        public FileData()//
        {
            try//
            {
                if (Directory.Exists(MyDocPathFolder))
                {
                    return;
                }
                DirectoryInfo di = Directory.CreateDirectory(MyDocPathFolder);
            }
            finally { }
        } 

        public bool SaveExists()//
        {
            if (File.Exists(MyDocPath + @FILE_NAME) && File.Exists(MyDocPath + @FILE_NAME_TWO))//
            {
                File.Decrypt(MyDocPath + @FILE_NAME);
                File.Decrypt(MyDocPath + @FILE_NAME_TWO);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SaveString(String Name, String Class,String Race,String gender)//
        {
            string[] STRING = {Name,Class,Race,gender};
            File.WriteAllLines(MyDocPath + @FILE_NAME, STRING);//
            Console.Clear();
            Console.Write("\n         Game Saved\n\n");
        }

        public void SaveInt(int HealthMax, int SpellPointsMax, int HealthPerLv, int SpellPointsMultiplier, int Strength, int Intelligence, int Wisdom, int Agility, int Charisma, int Luck, int CriticalStrike, int CriticalStrikePerLv, int Lv, int Health, int SpellPoints, int stage, int Exp)//
        {
            string[] INT = { "" + HealthMax, "" + SpellPointsMax, "" + HealthPerLv, "" + SpellPointsMultiplier, "" + Strength, "" + Intelligence, "" + Wisdom, "" + Agility, "" + Charisma, "" + Luck, "" + CriticalStrike, "" + CriticalStrikePerLv, "" + Lv, "" + Health, "" + SpellPoints, "" + stage, "" + Exp };
            File.WriteAllLines(MyDocPath + FILE_NAME_TWO, INT);//
            Console.Clear();
            Console.Write("\n         Game Saved\n\n");
        }

        public string[] LoadString()//
        {
            string[] ArrayLoadString = File.ReadAllLines(MyDocPath + @FILE_NAME);//
            return ArrayLoadString;
        }
        public string[] LoadInt()//
        {
            string[] ArrayLoadInt = File.ReadAllLines(MyDocPath + @FILE_NAME_TWO);//
            return ArrayLoadInt;
        }

        public void SaveEncrypt()//
        {
            File.Encrypt(MyDocPath + @FILE_NAME);//
            File.Encrypt(MyDocPath + @FILE_NAME_TWO);
        }


    }
}
