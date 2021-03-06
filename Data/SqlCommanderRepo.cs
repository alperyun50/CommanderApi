
using System;
using System.Collections.Generic;
using System.Linq;
using CommanderApi.Models;

namespace CommanderApi.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Commands.Add(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            // return all commands
            return _context.Commands.ToList();
            
        }

        public Command GetCommandById(int id)
        {
            // return command according to id
            return _context.Commands.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0); 
        }

        public void UpdateCommand(Command cmd)
        {
            // nothing
        }
    }
}