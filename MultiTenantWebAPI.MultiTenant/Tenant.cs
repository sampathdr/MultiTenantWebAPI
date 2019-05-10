using System.Collections.Generic;

namespace MultiTenantWebAPI.MultiTenant
{
  public class Tenant
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string ConnectionString { get; set; }
    public string AzureStorageConnStr { get; set; }
    public bool IsEnable { get; set; }

    public virtual ICollection<Host> Hosts { get; set; }
  }
}
