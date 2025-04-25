using System.Data.Entity;
using System; // not directly used but can be used for logging etc
using DALtry6; // not used either

public class AppDbContext : DbContext
{
    public AppDbContext() : base("name=DefaultConnection") { }

    //public DbSet<User> Users { get; set; }
}
