using Microsoft.EntityFrameworkCore;
using WebApplication.Domain;

namespace WebApplication.DbContexts
{
    public class ActionContext : DbContext
    {
        public ActionContext(DbContextOptions<ActionContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Action>()
                .HasKey(x => x.Id);
        }

        public DbSet<Action> Actions { get; set; }
    }
}