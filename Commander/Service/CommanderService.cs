using System.Collections.Generic;
using Commander.Models;
using Commander.Repository;

namespace Commander.Service
{
    public class CommanderService : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            throw new System.NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}