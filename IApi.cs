using System;
using System.Threading.Tasks;
using Refit;

namespace wpfrefit;

public interface IApi
{
  [Get("/{guid}")]
  public Task<string> Get(Guid guid);
}
