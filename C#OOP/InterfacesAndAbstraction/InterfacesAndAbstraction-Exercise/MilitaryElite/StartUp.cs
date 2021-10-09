using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<ISoldier> soldiers = new List<ISoldier>();
            string text = string.Empty;

            while ((text = Console.ReadLine()) != "End")
            {
                string[] command = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Private")
                {
                    var soldier = new Private(int.Parse(command[1]), command[2], command[3], decimal.Parse(command[4]));
                    soldiers.Add(soldier);
                }
                else if (command[0] == "LieutenantGeneral")
                {
                    var lieutenant = new LieutenantGeneral(int.Parse(command[1]), command[2], command[3], decimal.Parse(command[4]));
                    for (int i = 5; i < command.Length; i++)
                    {
                        var index = soldiers.FindIndex(n => n.Id == int.Parse(command[i]));
                        lieutenant.AddPrivate(soldiers[index]);
                    }

                    soldiers.Add(lieutenant);
                }
                else if (command[0] == "Engineer")
                {
                    var engineer = new Engineer(int.Parse(command[1]), command[2], command[3], decimal.Parse(command[4]), command[5]);
                    if (command[5] == "Airforces" || command[5] == "Marines")
                    {
                        for (int i = 6; i < command.Length; i += 2)
                        {
                            var repair = new Repair(command[i], int.Parse(command[i + 1]));
                            engineer.addRepair(repair);
                        }

                        soldiers.Add(engineer);
                    }

                }
                else if (command[0] == "Commando")
                {
                    if (command[5] == "Airforces" || command[5] == "Marines")
                    {
                        var commando = new Commando(int.Parse(command[1]), command[2], command[3], decimal.Parse(command[4]), command[5]);
                        for (int i = 6; i < command.Length; i += 2)
                        {
                            if (command[i + 1] == "Finished" || command[i + 1] == "inProgress")
                            {
                                var mission = new Mission(command[i], command[i + 1]);
                                commando.AddMission(mission);
                            }
                        }
                        soldiers.Add(commando);
                    }
                }
                else if (command[0] == "Spy")
                {
                    var spy = new Spy(int.Parse(command[1]), command[2], command[3], int.Parse(command[4]));
                    soldiers.Add(spy);
                }
            }
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
