using System;
using System.Collections.Generic;
using System.Text;

namespace MultiTenantWebAPI.Domain.Models.Base
{
  public interface IListItem : IEntity
  {
    string Name { get; set; }
    DateTime? DeletedDate { get; set; }
  }
}
