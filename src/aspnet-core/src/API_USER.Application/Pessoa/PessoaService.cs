using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using API_USER.Core;
using Microsoft.EntityFrameworkCore;

namespace API_USER.Application
{
    public class PessoaService : AsyncCrudAppService<Pessoa, PessoaDto, int, PagedPessoaResultRequestDto, CreatePessoaDto, PessoaDto>, IPessoa
    {
        public PessoaService(IRepository<Pessoa, int> repository) : base(repository)
        {
        }


    }
}
