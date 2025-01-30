using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Models
{
    public class TodoContext: DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
       : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem { Id = 1, Description = "Complete assignment#1", IsCompleted = false },
                
            );
        }
    }
}
