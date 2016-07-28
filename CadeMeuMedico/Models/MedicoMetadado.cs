using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(MedicoMetadado))] //informa qual o tipo da classe que possui os metadados que serao utilizados.
    public partial class Medico
    {
    }
    public class MedicoMetadado
    {
        [Required(ErrorMessage="Obrigatorio informar o CRM")] [StringLength(30,ErrorMessage="O CRM deve possuir no maximo 30 caracteres")]
        public string CRM { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o nome")] [StringLength(80, ErrorMessage = "O Nome deve possuir no maximo 80 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o Endereco")] [StringLength(100, ErrorMessage = "O Endereco deve possuir no maximo 100 caracteres")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o Bairro")] [StringLength(60, ErrorMessage = "O Bairro deve possuir no maximo 60 caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o E-mail")] [StringLength(100, ErrorMessage = "O Email deve possuir no maximo 100 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar se atende por convenio")]
        public bool AtendePorConvenio { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar se tem Clinica")] 
        public bool TemClinica { get; set; }

        [StringLength(80, ErrorMessage = "O Website deve possuir no maximo 80 caracteres")]
        public string WebsiteBlog { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a cidade")]
        public int IDCidade { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a Especialidade")]
        public int IDEspecialidade { get; set; }

    }
}