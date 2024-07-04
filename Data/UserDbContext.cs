using Microsoft.EntityFrameworkCore;

using UserIdentity.Models.Entity;

namespace UserIdentity.Data;

public class UserDbContext : DbContext
{
    public UserDbContext()
    {
    }

    public UserDbContext(DbContextOptions<UserDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }
}