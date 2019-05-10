namespace MultiTenantWebAPI.MultiTenant
{
  public class Host
  {
    public int Id { get; set; }
    public int TenantId { get; set; }
    public string HostName { get; set; }

    public virtual Tenant Tenant { get; set; }
  }
}
