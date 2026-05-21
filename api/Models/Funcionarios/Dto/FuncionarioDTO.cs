using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace api.Models.Funcionario.Dto
{
    public class FuncionarioDTO
    {
        [Required(ErrorMessage = "O salário é obrigatório")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Digite um valor acima de 0!")]
        public decimal Salario { get; set; }
    }
}