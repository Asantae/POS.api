using Microsoft.EntityFrameworkCore;
using POS.Models;

namespace POS.Data;

public class IDbContext : DbContext
{
    public IDbContext(DbContextOptions<IDbContext> options)
        :base(options)
    {

    }

    public DbSet<Issue> Issues { get; set; }
}