using AutoMapper;
using API_USER.Authorization.Users;
using API_USER.Application;
using API_USER.Core;

namespace API_USER.Users.Dto
{
    public class PessoaMapProfile : Profile
    {
        public PessoaMapProfile()
        {
            CreateMap<PessoaDto, Pessoa>().ReverseMap();
                    
        }
    }
}
