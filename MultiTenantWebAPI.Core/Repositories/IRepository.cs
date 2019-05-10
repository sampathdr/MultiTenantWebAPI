using MultiTenantWebAPI.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MultiTenantWebAPI.Core.Repositories
{
  public interface IRepository<T> : IDisposable where T : class, IEntity
  {
    IQueryable<T> All { get; }
    IQueryable<T> AllAsNoTracking { get; }
    IQueryable<T> Query(Expression<Func<T, bool>> filter);
    T Find(int id);
    void InsertOrUpdate(T entity);
    void InsertBulk(IEnumerable<T> entities);
    void Delete(int id);
    void Delete(T entity);
    void Delete(IEnumerable<T> entities);
    void DeleteBulk(IEnumerable<T> entities);
    void Update(T entity);
    T GetById(int id);
    Task<T> FindAsync(int id);
  }
}
