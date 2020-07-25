using System.Collections.Generic;
using Commander.Models;
using Commander.Repository;

namespace Commander.Service
{
    public class CommanderService : ICommanderRepo
    {
        public CommanderService(CommanderContext context)
        {

        }

        public IEnumerable<Command> GetAllCommands()
        {

        }

        public Command GetCommandById(int id)
        {

        }
    }
}