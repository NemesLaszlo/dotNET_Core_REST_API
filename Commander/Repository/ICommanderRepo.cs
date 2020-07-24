using System.Collections.Generic;
using Commander.Models;

namespace Commander.Repository
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
        
    }

}