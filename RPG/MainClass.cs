///-----------------------------------------------------------------
///   Namespace:      RPG
///   Class:          MainClass
///   Description:    This is the main class of the program that executes the entire program
///   Author:         Steve Schnell                    Date: 5/2/2016
///-----------------------------------------------------------------

using System;
using System.Threading;
using System.Windows.Forms;

/* -- static -----------------------------------------------------------------
** void
** Main()
**
** Description:This is the main method which executes the entire program
** -------------------------------------------------------------------------*/

namespace RPG
{
    class MainClass
    {
        static void Main()//
        {
            int Lv = 1,
                Health = 1,
                SpellPoints = 0,
                stage = 0,
                tempStage = 0,
                Exp = 0;

            Random rnd = new Random();

            //(int stag, int TextNum, int NumOfchoices, int choices01, int choices02, int choices03, int choices04 , int specal choices)
            int[,] MasterList = {{ 0,0,2,1,2,0,0,0},//
                                 { 1,0,1,2,0,0,0,0},
                                 { 2,0,1,1,0,0,0,3},
                                 { 3,0,2,1,2,0,0,0},
                                 { 4,0,3,5,6,7,0,0},
                                 { 5,0,2,8,4,0,0,0},
                                 { 6,0,2,4,8,0,0,0},
                                 { 7,0,2,5,6,0,0,0},
                                 { 8,0,2,6,9,0,0,0},
                                 { 9,0,3,11,10,8,0,0},
                                 { 10,0,1,9,0,0,0,0},
                                 { 11,0,3,12,13,10,0,0},
                                 { 12,0,1,11,0,0,0,0},
                                 { 13,0,2,14,12,0,0,0},
                                 { 14,0,3,13,15,16,0,0},
                                 { 15,0,2,14,20,0,0,0},
                                 { 16,0,2,14,17,0,0,0},
                                 { 17,0,2,16,18,0,0,0},
                                 { 18,0,3,19,17,15,0,0},
                                 { 19,0,1,18,0,0,0,0},
                                 { 20,0,2,15,21,0,0,0},
                                 { 21,0,2,22,15,0,0,0},
                                 { 22,0,0,0,0,0,0,0},
                                 { 23,0,1,24,0,0,0,0},
                                 { 24,0,3,25,26,27,0,0},
                                 { 25,0,0,0,0,0,0,0},
                                 { 26,0,0,0,0,0,0,0},
                                 { 27,0,0,0,0,0,0,0}};

            Console.SetWindowSize(110, 25);//

            FileData Data = new FileData();//
            CharacterCreator Creator = new CharacterCreator();//
            CharacterStatistics Stat = new CharacterStatistics();//
            DungeonMasterClass DM = new DungeonMasterClass();//

            Creator.TitleScreen();//

            if (Data.SaveExists())
            {
                if (MessageBox.Show("A previously saved file has been detected!\n\nLoad the Saved file?", "Phantom of Arcadia: The Sword of War", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//
                {
                    //
                    string[] STRING = Data.LoadString();
                    string[] INT = Data.LoadInt();
                    Creator.RName = STRING[0];
                    Creator.RClass = STRING[1];
                    Creator.RRace = STRING[2];
                    Creator.RGender = STRING[3];
                    Stat.ReturnHealthMax = Int32.Parse(INT[0]);
                    Stat.ReturnSpellPointsMax = Int32.Parse(INT[1]);
                    Stat.ReturnHealthPerLv = Int32.Parse(INT[2]);
                    Stat.ReturnSpellPointsMultiplier = Int32.Parse(INT[3]);
                    Stat.ReturnStrength = Int32.Parse(INT[4]);
                    Stat.ReturnIntelligence = Int32.Parse(INT[5]);
                    Stat.ReturnWisdom = Int32.Parse(INT[6]);
                    Stat.ReturnAgility = Int32.Parse(INT[7]);
                    Stat.ReturnCharisma = Int32.Parse(INT[8]);
                    Stat.ReturnLuck = Int32.Parse(INT[9]);
                    Stat.ReturnCriticalStrike = Int32.Parse(INT[10]);
                    Stat.ReturnCriticalStrikePerLv = Int32.Parse(INT[11]);
                    Lv = Int32.Parse(INT[12]);
                    Health = Int32.Parse(INT[13]);
                    SpellPoints = Int32.Parse(INT[14]);
                    stage = Int32.Parse(INT[15]);
                    Exp = Int32.Parse(INT[16]);
                }
                else//
                {
                    //
                    Creator.CCBackground();
                    Creator.CCClasses();
                    Creator.CCGender();
                    Creator.CCName();
                    Creator.CCRace();
                    Creator.CCsummary();
                    Stat.CSCalculateRaceGender(Creator.RRace, Creator.RGender);
                    Stat.CSCalculateClass(Creator.RClass);
                    Stat.CSCalculateLvUp(10, 1, 0, Creator.RName, Creator.RClass, Creator.RRace, Creator.RGender, 0);
                    Health = Stat.ReturnHealthMax;
                    SpellPoints = Stat.ReturnSpellPointsMax;

                }
            }
            else//
            {
                //
                Creator.CCBackground();
                Creator.CCClasses();
                Creator.CCGender();
                Creator.CCName();
                Creator.CCRace();
                Creator.CCsummary();
                Stat.CSCalculateRaceGender(Creator.RRace, Creator.RGender);
                Stat.CSCalculateClass(Creator.RClass);
                Stat.CSCalculateLvUp(10, 1, 0, Creator.RName, Creator.RClass, Creator.RRace, Creator.RGender, 0);
                Health = Stat.ReturnHealthMax;
                SpellPoints = Stat.ReturnSpellPointsMax;

            }

            //
            Data.SaveString(Creator.RName, Creator.RClass, Creator.RRace, Creator.RGender);
            Data.SaveInt(Stat.ReturnHealthMax, Stat.ReturnSpellPointsMax, Stat.ReturnHealthPerLv, Stat.ReturnSpellPointsMultiplier, Stat.ReturnStrength, Stat.ReturnIntelligence, Stat.ReturnWisdom, Stat.ReturnAgility, Stat.ReturnCharisma, Stat.ReturnLuck, Stat.ReturnCriticalStrike, Stat.ReturnCriticalStrikePerLv, Lv, Health, SpellPoints, stage, Exp);

            //start end**************************************

            

            while (tempStage < 999)//
            {
                
                int Random001 = rnd.Next(1, 5);//

                if (stage != 0 && stage != 1 && stage != 2 && stage != 3 && stage != 4 && stage != 20 && stage != 21 && stage != 22 && stage != 23 && stage != 24 && stage != 25 && stage != 26 && stage != 27)
                {
                    if (Random001 > 2 && tempStage == stage)
                    {
                        Exp += DM.Combat(Lv, stage, ref Health, ref SpellPoints, Creator.RName, Stat.ReturnStrength, Stat.ReturnWisdom, Stat.ReturnIntelligence, Stat.ReturnAgility, Stat.ReturnCriticalStrike);//
                    }
                }

                if(stage == 22)//
                {
                    tempStage = DM.Riddle001();//
                }

                if (Exp >= 99999999)//
                {
                    DM.GG();
                    break;
                }


                if (Exp >= Lv * (Lv * 75))//
                {
                    Lv++;
                    Stat.CSCalculateLvUp(2, Lv, Exp, Creator.RName, Creator.RClass, Creator.RRace, Creator.RGender, 1);//
                }

                if(stage != 22)//
                {
                    tempStage = DM.DungeonMaster(MasterList[stage, 0], MasterList[stage, 1], MasterList[stage, 2], MasterList[stage, 3], MasterList[stage, 4], MasterList[stage, 5], MasterList[stage, 6], MasterList[stage, 7]);
                }


                if(stage == 3)//
                {
                    MasterList[1, 1] = 1;
                    MasterList[2, 7] = 0;
                    MasterList[2, 1] = 1;
                    MasterList[1, 7] = 4;
                }
                if (stage == 4)//
                {
                   MasterList[1, 1] = 2;                   
                }
                if(tempStage == 998)//
                {
                    Stat.CSCalculatePrint(Lv, Exp, Creator.RName, Creator.RClass, Creator.RRace, Creator.RGender, Health, SpellPoints);
                }
                else if (tempStage == 999)//
                {
                }
                else
                {
                    stage = tempStage;

                    if (Health < Stat.ReturnHealthMax)//
                        Health += Stat.ReturnLuck / 2;

                    if (SpellPoints < Stat.ReturnSpellPointsMax)//
                        SpellPoints += Stat.ReturnLuck / 2;
                }

                if (Health >= Stat.ReturnHealthMax)//
                    Health = Stat.ReturnHealthMax;

                if (SpellPoints >= Stat.ReturnSpellPointsMax)//
                    SpellPoints = Stat.ReturnSpellPointsMax;

                Data.SaveString(Creator.RName, Creator.RClass, Creator.RRace, Creator.RGender);//
                Data.SaveInt(Stat.ReturnHealthMax, Stat.ReturnSpellPointsMax, Stat.ReturnHealthPerLv, Stat.ReturnSpellPointsMultiplier, Stat.ReturnStrength, Stat.ReturnIntelligence, Stat.ReturnWisdom, Stat.ReturnAgility, Stat.ReturnCharisma, Stat.ReturnLuck, Stat.ReturnCriticalStrike, Stat.ReturnCriticalStrikePerLv, Lv, Health, SpellPoints, stage, Exp);//

            }

            /**

            Data.SaveEncrypt();

            ERROR:Recovery policy configured for this system contains invalid recovery certificate

            Error message when client computers encrypt a file in a Windows Server 2003 domain: “Recovery
            policy configured for this system contains invalid recovery certificate”

            CAUSE:This problem occurs if the EFS recovery policy that is implemented on the client
            computer contains one or more EFS recovery agent certificates that have expired. Client
            computers cannot encrypt any new documents until a valid recovery agent certificate
            is available.
            
            **/
        }


    }

}
    

