using System.Collections.Generic;
using CommanderApi.Models;

namespace CommanderApi.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}