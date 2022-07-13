///-----------------------------------------------------------------
///   Namespace:      RPG
///   Class:          MonsterList
///   Description:    This class contains all the data of all the different kinds of enemies that can be encountered in the game
///   Author:         Steve Schnell                    Date: 5/2/2016
///-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* -- public -----------------------------------------------------------------
** string
** MonsterMaster(int X, int Y)
**
** Description:Returns the name and attacks of a monster
** -------------------------------------------------------------------------*/

/* -- public -----------------------------------------------------------------
** int
** MonsterNumberMaster(int X, int Y)
**
** Description:Returns the level hp and demage of a monster
** -------------------------------------------------------------------------*/

namespace RPG
{
    class MonsterList
    {
        string[,] MasterMonsterList = {{"Rat","Bite","Scratch ",},//
                                      {"Brown Rat","Bite ","Scratch",},
                                      {"Spider","Bite","Bite",},
                                      {"Horned Spider","Bite","Bite",},
                                      {"Goblin","Slashing Attack","Scratch"},
                                      {"Skeleton","Heavy Strike","Uppercut"},
                                      {"Zombie","Bite","Uppercut"},
                                      {"Big Spider","Bite","Scratch"},
                                      {"Goblin Warrior","Heavy Strike","Slashing Attack"},
                                      {"Skeleton Mage","Icy Spear","Firebolt"},
                                      {"Assassin Rat","Assassinate","Scratch"},
                                      {"Spider Zombie","Bite","Scratch"},
                                      {"Zombie Lord","Heavy Attack","Firebolt"},
                                      {"Skeleton Knight","Executioner","Heavy Attack"}};

        int[,] MasterMonsterNumberList ={{1,15,9},//
                                        {1,15,11},
                                        {1,20,13},
                                        {2,25,14},
                                        {3,30,15},
                                        {3,35,16},
                                        {4,40,18},
                                        {4,45,19},
                                        {5,50,21},
                                        {5,55,23},
                                        {6,60,25},
                                        {6,65,26},
                                        {7,70,28},
                                        {7,75,30}};

        public string MonsterMaster(int X, int Y)//
        {
            return MasterMonsterList[X, Y];
        }

        public int MonsterNumberMaster(int X, int Y)//
        {
            return MasterMonsterNumberList[X, Y];
        }
    }
}
