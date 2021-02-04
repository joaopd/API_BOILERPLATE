using Abp.Application.Services;
using Abp.Domain.Repositories;
using API_USER.Core;

namespace API_USER.Application
{
  public interface IPessoa : IAsyncCrudAppService<PessoaDto, int, PagedPessoaResultRequestDto, CreatePessoaDto, PessoaDto>
  {
  }
}
