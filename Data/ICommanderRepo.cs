using System.Collections.Generic;
using CommanderApi.Models;

namespace CommanderApi.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        bool SaveChanges();
    }
}