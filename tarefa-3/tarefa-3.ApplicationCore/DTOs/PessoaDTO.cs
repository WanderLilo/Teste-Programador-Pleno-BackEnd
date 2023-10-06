using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_3.ApplicationCore.DTOs
{
    public class PessoaDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório !")]
        [StringLength(60, ErrorMessage = "{0} deve ter no maximo {1} caracteres !")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "{0} é obrigatório !")]
        [StringLength(14, ErrorMessage = "{0} deve ter {1} caracteres !", MinimumLength = 14)]
        public string Cpf { get; set; }


        [Required(ErrorMessage = "{0} é obrigatório !")]
        public int CidadeId { get; set; }
    }
}
