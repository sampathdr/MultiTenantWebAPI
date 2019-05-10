using MultiTenantWebAPI.Domain.Models.Base;
using System.Linq;

namespace MultiTenantWebAPI.Core.Repositories
{
  public interface IListRepository<T> : IRepository<T> where T : class, IListItem
  {
    int GetIdFromText(string text, bool checkIsDeleted = true);
    string GetTextFromId(int id);
    T Get(string text);
    IQueryable<T> ActiveAll { get; }
  }
}
