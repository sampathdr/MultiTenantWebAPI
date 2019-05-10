using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiTenantWebAPI.MultiTenant
{
  public class TenantResolverService : ITenantResolverService
  {
    private readonly TenantDBContext _tenantDBContext;
    private readonly IMemoryCache _cache;
    private List<Tenant> _tenants;
    private readonly object _syncroot = new object();

    public List<Tenant> Tenants
    {
      get
      {
        lock (_syncroot)
        {
          return _tenants;
        }
      }
    }

    public TenantResolverService(IMemoryCache cache, TenantDBContext tenantDBContext)
    {
      _tenantDBContext = tenantDBContext;
      _cache = cache;
      LoadTenants();
    }

    private void LoadTenants()
    {
      lock (_syncroot)
      {
        _tenants = _cache.Get<List<Tenant>>(CacheKeys.Tenants);

        if (_tenants == null)
        {
          LoadTenantsInternal();
        }
      }
    }

    private void LoadTenantsInternal()
    {
      _tenants = _tenantDBContext.Tenants.Include("Hosts").ToList();
      _cache.Set(CacheKeys.Tenants, _tenants, new TimeSpan(0, 10, 0));
    }

    //Load Tenants forcefully
    public void ReLoadTenants()
    {
      lock (_syncroot)
      {
        LoadTenantsInternal();
      }
    }

    public Tenant ResolveByHost(string host)
    {
      Tenant tenant = Tenants.Where(t => t.IsEnable)
                      .SingleOrDefault(t => t.Hosts.Any(h => h.HostName.Equals(host, StringComparison.OrdinalIgnoreCase)));

      if (tenant == null)
      {
        return null;
      }

      return tenant;
    }

    public Tenant ResolveByTenantName(string tenantName)
    {
      Tenant tenant = Tenants.Where(t => t.IsEnable)
                      .SingleOrDefault(t => t.Name.Equals(tenantName, StringComparison.OrdinalIgnoreCase));

      if (tenant == null)
      {
        return null;
      }

      return tenant;
    }
  }
}
