namespace MultiTenantWebAPI.MultiTenant
{
  public interface ITenantResolverService
  {
    //void LoadTenants();
    Tenant ResolveByHost(string host);
    Tenant ResolveByTenantName(string tenantName);
    void ReLoadTenants();
  }
}
