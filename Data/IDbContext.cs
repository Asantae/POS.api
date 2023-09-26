using System;
using Microsoft.EntityFrameworkCore;
using POS.Models;

namespace POS.Data;

public class IDbContext : DbContext
{
    public IDbContext(DbContextOptions<IDbContext> options)
        :base(options)
    {
        Console.WriteLine("test");
    }

    public DbSet<Issue> Issues { get; set; }
}