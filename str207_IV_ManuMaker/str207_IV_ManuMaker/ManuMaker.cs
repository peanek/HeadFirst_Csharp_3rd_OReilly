using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str207_IV_ManuMaker
{
    class ManuMaker
    {
        public Random Randomizer;

        string[] Meats = { "Grilled beef","Salami","Turkey","Ham","Kark"};
        string[] Condiments = {"Mustard","Mustard2","Honey","Majo","Spices","French souce"};
        string[] Breads = { "Rice bread", "youth bread", "pumpernikel", "bread5", "bread6" };

        public String GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondi = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat+randomCondi+randomBread;

        }


    }
}
