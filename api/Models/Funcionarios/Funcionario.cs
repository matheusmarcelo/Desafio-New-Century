using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models.Funcionario
{
    public class Funcionario
    {
        public decimal Salario { get; set; }
        public int PercentualAumento { get; set; }
        public decimal ValorAumento { get; set; }
        public decimal SalarioPosReajuste { get; set; }
    }
}