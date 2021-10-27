using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            const string INVALID = "Invalid hero!";
            const string WIN = "Victory!";
            const string LOSE = "Defeat...";

            int heroesToAdd = int.Parse(Console.ReadLine());
            List<BaseHero> raidGroup = new List<BaseHero>();

            while (raidGroup.Count != heroesToAdd)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();
                BaseHero hero = null;
                bool inputIsValid = true;

                if (heroType == "Paladin")
                {
                    hero = new Paladin(heroName);
                }
                else if (heroType == "Druid")
                {
                    hero = new Druid(heroName);
                }
                else if (heroType == "Warrior")
                {
                    hero = new Warrior(heroName);
                }
                else if (heroType == "Rogue")
                {
                    hero = new Rogue(heroName);
                }
                else
                {
                    inputIsValid = false;
                    Console.WriteLine(INVALID);
                }

                if (inputIsValid)
                {
                    raidGroup.Add(hero);
                }
            }
            int heroPower = int.Parse(Console.ReadLine());
            foreach (var hero in raidGroup)
            {
                Console.WriteLine(hero.CastAbility());
            }
            
            int raidPower = raidGroup.Sum(n => n.Power);

            if (raidPower >= heroPower)
            {
                Console.WriteLine(WIN);
            }
            else
            {
                Console.WriteLine(LOSE);
            }
        }
    }
}
