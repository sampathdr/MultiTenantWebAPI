using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiTenantWebAPI.MultiTenant
{
  //public class TenantResolver
  //{
  //  private static TenantResolver _Instance = null;
  //  private List<Tenant> _tenants;
  //  private static object _syncroot = new object();

  //  public List<Tenant> Tenants
  //  {
  //    get
  //    {
  //      lock (_syncroot)
  //      {
  //        return _tenants;
  //      }
  //    }
  //  }

  //  private TenantResolver()
  //  {
  //    LoadTenants();
  //  }

  //  public void LoadTenants()
  //  {
  //    lock (_syncroot)
  //    {
  //      var optionsBuilder = new DbContextOptionsBuilder<TenantDBContext>();
  //      optionsBuilder.UseSqlServer("Data Source=DESKTOP-TGEDV7P\\SQLEXPRESS;Initial Catalog=fboTenantDB;User ID=sa;Password=1qaz2wsx@; MultipleActiveResultSets=True");
  //      TenantDBContext db = new TenantDBContext(optionsBuilder.Options);
  //      _tenants = db.Tenants.Include("Hosts").ToList();
  //    }
  //  }

  //  public static TenantResolver Instance
  //  {
  //    get
  //    {
  //      if (_Instance == null)
  //        _Instance = new TenantResolver();

  //      return _Instance;
  //    }
  //  }

  //  public Tenant ResolveByHost(string host)
  //  {
  //    Tenant tenant = Tenants.SingleOrDefault(t => t.Hosts.Any(h => h.HostName.Equals(host,StringComparison.OrdinalIgnoreCase)));

  //    if (tenant == null)
  //    {
  //      return null;
  //    }

  //    return tenant;
  //  }

  //  public Tenant ResolveByTenantName(string tenantName)
  //  {
  //    Tenant tenant = Tenants.SingleOrDefault(t => t.Name.Equals(tenantName, StringComparison.OrdinalIgnoreCase));

  //    if (tenant == null)
  //    {
  //      return null;
  //    }

  //    return tenant;
  //  }
  //}
}
