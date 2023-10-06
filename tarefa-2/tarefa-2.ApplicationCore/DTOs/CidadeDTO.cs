using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_2.ApplicationCore.DTOs
{
    public class CidadeDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório !")]
        [StringLength(60, ErrorMessage = "{0} deve ter no maximo {1} caracteres !")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "{0} é obrigatório !")]
        [StringLength(2, ErrorMessage = "{0} deve ter {1} caracteres !", MinimumLength = 2)]
        public string EstadoId { get; set; }
    }
}
