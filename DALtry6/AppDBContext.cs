using System.Data.Entity;
using System;
using DALtry6;

public class AppDbContext : DbContext
{
    public AppDbContext() : base("name=DefaultConnection") { }

    //public DbSet<User> Users { get; set; }
}
