using Microsoft.EntityFrameworkCore;

namespace POS.Data;

public interface IDbContext : DbContext
{
    IDbContext AsNew();
    
    EntityEntry Entry(object entry);
    DatabaseFacade Database { get; }

}