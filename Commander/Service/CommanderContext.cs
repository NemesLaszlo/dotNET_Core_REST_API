using Commander.Models;
using Microsoft.EntityFrameworkCore;
using Commander.Entities;

namespace Commander.Service
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> options) : base(options)
        {

        }

        public DbSet<Command> Commands { get; set; }
        public DbSet<User> Users { get; set; }

    }
}