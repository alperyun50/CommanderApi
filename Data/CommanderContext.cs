
using CommanderApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CommanderApi.Data
{
    public class CommanderContext : DbContext
    {
       public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
       {
           
       }

       public DbSet<Command> Commands {get; set;}
    }
}