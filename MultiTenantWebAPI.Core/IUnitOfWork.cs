using MultiTenantWebAPI.Core.Repositories;
using MultiTenantWebAPI.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenantWebAPI.Core
{
  public interface IUnitOfWork
  {
    Task<List<TResult>> ListAsync<TResult>(IQueryable<TResult> query);
    Task<TResult[]> ArrayAsync<TResult>(IQueryable<TResult> query);
    TResult[] ToArray<TResult>(IQueryable<TResult> query);
    void Save();
    Task<int> SaveAsync();
    IRepository<T> Repository<T>() where T : class, IEntity;
    IListRepository<T> ListRepository<T>() where T : class, IListItem;
    IQueryRepository<T> QueryRepository<T>() where T : struct;
  }
}
