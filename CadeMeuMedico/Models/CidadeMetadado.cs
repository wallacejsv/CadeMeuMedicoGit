using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(CidadeMetadado))]
    public partial class Cidade
    {
    }

    public class CidadeMetadado
    {
        [Required(ErrorMessage = "Obrigatorio informar o nome")] [StringLength(80, ErrorMessage = "O nome deve possuir no maximo 100 Caracteres")]
        public string Nome { get; set; }
    }
}