using System.Collections.Generic;
using Commander.Models;
using Commander.Repository;

namespace Commander.Service
{
    public class CommanderService : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil am egg", Line = "Boil water", Platform = "Kettle & Pan" },
                new Command { Id = 1, HowTo = "Cut bread", Line = "Get a Knife", Platform = "Knife" },
                new Command { Id = 2, HowTo = "Make a cup of tea", Line = "Place in cup", Platform = "Kettle & Pan" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil am egg", Line = "Boil water", Platform = "Kettle & Pan" };
        }
    }
}