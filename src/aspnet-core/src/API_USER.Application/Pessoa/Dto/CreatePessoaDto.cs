using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;
using API_USER.Core;

namespace API_USER.Application
{
  public class CreatePessoaDto : Entity
  {

    [Required(ErrorMessage = "Nome e um campo obrigatorio")]
    [StringLength(256, ErrorMessage = "Tamanho maximo e de {1} caracteres")]
    public string Nome { get; set; }

    public DateTime DataNasc { get; set; }

    [MaxLength(11, ErrorMessage = "Tamanho maximo de {1} caracteres")]
    [MinLength(11, ErrorMessage = "Tamanho minimo de {1} caracteres")]
    public string Cpf { get; set; }
    public string Profissao { get; set; }
    public EstadoCivilEnum EstadoCivil { get; set; }
    public SexoEnum Sexo { get; set; }
    public string Nacionalidade { get; set; }

    [MaxLength(11, ErrorMessage = "Tamanho maximo de {1} caracteres")]
    public string Telefone { get; set; }

    [Required(ErrorMessage = "Email e um campo obrigatorio")]
    [StringLength(100, ErrorMessage = "Tamanho maximo e de {1} caracteres")]
    [EmailAddress(ErrorMessage = "Email no formato invalido")]
    public string Email { get; set; }
  }
}
