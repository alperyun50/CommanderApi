using System.Collections.Generic;
using CommanderApi.Models;

namespace CommanderApi.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>()
            {
                new Command() {Id=0, HowTo="boil a egg", Line="boil water", Platform="Kettle & pan"},
                new Command() {Id=1, HowTo="cut bread", Line="get a knive", Platform="knife & chopping board"},
                new Command() {Id=2, HowTo="make cup of tea", Line="place teabag in cup", Platform="kettle & cup"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="boil a egg", Line="boil water", Platform="Kettle & pan"};
        }
    }
}