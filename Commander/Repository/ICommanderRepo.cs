using System.Collections.Generic;
using Commander.Models;

namespace Commander.Repository
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command newCommand);
        void UpdateCommand(Command updateCommand);
        void DeleteCommand(Command deleteCommand);
        void DeleteAllCommand(IEnumerable<Command> allCommand);

    }

}