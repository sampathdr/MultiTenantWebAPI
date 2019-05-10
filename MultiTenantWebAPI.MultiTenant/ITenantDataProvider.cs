namespace MultiTenantWebAPI.MultiTenant
{
  public interface ITenantDataProvider
  {
    Tenant CurrentTenant { get; set; }
  }

  public class TenantDataProvider : ITenantDataProvider
  {
    public Tenant CurrentTenant { get; set; }
  }
}
