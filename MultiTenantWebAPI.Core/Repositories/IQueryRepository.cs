using System.Collections.Generic;

namespace MultiTenantWebAPI.Core.Repositories
{
  public interface IQueryRepository<T> where T : struct
  {
    List<T> RunSqlQueryToGetList(string query, params object[] parameters);
  }
}
