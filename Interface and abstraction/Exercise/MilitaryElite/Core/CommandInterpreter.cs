using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;

namespace MilitaryElite.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private Dictionary<int, ISolder> solders;

        public CommandInterpreter()
        {
            this.solders = new Dictionary<int, ISolder>();
        }

        public string Read(string[] args)
        {
            string solderType = args[0];
            int id = int.Parse(args[1]);
            string firstName = args[2];
            string lastName = args[3];

            ISolder solder = null;

            if (solderType == "Private")
            {
                decimal salary = decimal.Parse(args[4]);
                solder = new Private(id, firstName, lastName, salary);
            }
            else if (solderType == "LieutenantGeneral")
            {
                decimal salary = decimal.Parse(args[4]);
                var privates = new Dictionary<int, IPrivate>();

                for (int i = 5; i < args.Length; i++)
                {
                    int solderId = int.Parse(args[i]);
                    var currentSolder = (IPrivate)solders[solderId];
                    privates.Add(solderId, currentSolder);
                }

                solder = new LieutenantGeneral(id, firstName, lastName, salary, privates);
            }
            else if (solderType == "Engineer")
            {
                decimal salary = decimal.Parse(args[4]);

                bool isValidCorps = Enum.TryParse<Corps>(args[5], out Corps corps);

                if (!isValidCorps)
                {
                    //TODO throw exeption and catch it in the Engine
                    return null;
                }

                ICollection<IRepair> repairs = new List<IRepair>();

                for (int i = 6; i < args.Length; i+=2)
                {
                    string currentName = args[i];
                    int hours = int.Parse(args[i + 1]);

                    IRepair repair = new Repair(currentName, hours);

                    repairs.Add(repair);
                }

                solder = new Engineer(id, firstName, lastName, salary, corps, repairs);
            }
            else if (solderType == "Commando")
            {
                decimal salary = decimal.Parse(args[4]);

                bool isValidCorps = Enum.TryParse<Corps>(args[5], out Corps corps);

                if (!isValidCorps)
                {
                    //TODO throw exeption and catch it in the Engine
                    return null;
                }


                ICollection<IMission> missions = new List<IMission>();

                for (int i = 6; i < args.Length; i += 2)
                {
                    string missionName = args[i];
                    string missionState = args[i + 1];

                    bool IsValidMissionState = Enum.TryParse<State>(missionState, out State stateResult);

                    if (!IsValidMissionState)
                    {
                        //TODO throw exeption and catch it in the Engine
                        return null;
                    }

                    IMission mission = new Mission(missionName, stateResult);

                    missions.Add(mission);
                }

                solder = new Commando(id, firstName, lastName, salary, corps, missions);
            }
            else if (solderType == "Spy")
            {
                int codeNumber = int.Parse(args[3]);
                solder = new Spy(id, firstName, lastName, codeNumber);
            }
            solders.Add(id, solder);

            return solder.ToString();

            
        }
    }
}
