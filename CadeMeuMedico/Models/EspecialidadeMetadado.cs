using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(EspecialidadeMetadado))]
    public partial class Especialidade { }

    public class EspecialidadeMetadado
    {
        [Required(ErrorMessage = "Obrigatorio informar o Nome")] [StringLength(80, ErrorMessage = "O nome deve possuir no maximo 80 Caracteres")]
        public string Nome { get; set; }
    }
}