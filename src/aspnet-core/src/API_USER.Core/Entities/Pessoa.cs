using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace API_USER.Core
{
  public class Pessoa : Entity<int>
  {

    public string Nome { get; set; }
    public DateTime DataNasc { get; set; }
    public string Cpf { get; set; }
    public string Profissao { get; set; }
    public EstadoCivilEnum EstadoCivil { get; set; }
    public SexoEnum Sexo { get; set; }
    public string Nacionalidade { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

  }
}
