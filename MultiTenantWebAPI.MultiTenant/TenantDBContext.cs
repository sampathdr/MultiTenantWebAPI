using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace MultiTenantWebAPI.MultiTenant
{
  public interface IDbContext : IDisposable
  {
    DbSet<T> Set<T>() where T : class;
    int SaveChanges();
    Task<int> SaveChangesAsync();
  }

  public class TenantDBContext : DbContext, IDbContext
  {
    public TenantDBContext(DbContextOptions<TenantDBContext> options) : base(options)
    {

    }

    //public override int SaveChanges()
    //{
    //  var added =
    //    this.ChangeTracker.Entries()
    //      .Where(x => x.State == EntityState.Added)
    //      .Select(x => x.Entity)
    //      .ToList();
    //  var modified =
    //    this.ChangeTracker.Entries()
    //      .Where(x => x.State == EntityState.Modified)
    //      .Select(x => x.Entity)
    //      .ToList();
    //  var deleted = this.ChangeTracker.Entries()
    //    .Where(x => x.State == EntityState.Deleted)
    //    .Select(x => x.Entity)
    //    .ToList();

    //  return base.SaveChanges();
    //}

    public Task<int> SaveChangesAsync()
    {
      throw new NotImplementedException();
    }

    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<Host> Hosts { get; set; }
  }
}
