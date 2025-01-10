using Microsoft.EntityFrameworkCore;

namespace W14_Jwt.Data;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<User> Users { get; set; }

    // seed data for testing
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Email = "test1@test.com", Password = "test1" },
            new User { Id = 2, Email = "test2@test.com", Password = "test2" },
            new User { Id = 3, Email = "test3@test.com", Password = "test3" },
            new User { Id = 4, Email = "test4@test.com", Password = "test4" }
        );
    }
}