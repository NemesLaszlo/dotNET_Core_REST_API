using System.Collections.Generic;
using System.Linq;
using Commander.Models;
using Commander.Repository;

namespace Commander.Service
{
    public class CommanderService : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public CommanderService(CommanderContext context)
        {
            _context = context;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}