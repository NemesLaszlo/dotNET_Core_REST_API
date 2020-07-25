using System;
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

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public void CreateCommand(Command newCommand)
        {
            if (newCommand == null)
            {
                throw new ArgumentNullException(nameof(newCommand));
            }

            _context.Commands.Add(newCommand);
        }

        public void UpdateCommand(Command updateCommand)
        {

        }

        public void DeleteCommand(Command deleteCommand)
        {
            if (deleteCommand == null)
            {
                throw new ArgumentNullException(nameof(deleteCommand));
            }

            _context.Commands.Remove(deleteCommand);
        }

        public void DeleteAllCommand(IEnumerable<Command> allCommand)
        {
            allCommand.ToList().ForEach(i => { _context.Commands.Remove(i); });
        }
    }
}