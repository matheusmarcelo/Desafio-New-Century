using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api;
using api.Models.Funcionario.Dto;
using api.Services.FuncionarioService;

namespace projeto_console.Tests
{
    public class FuncionarioServiceTests
    {
        private readonly FuncionarioService _funcionarioService;

        public FuncionarioServiceTests()
        {
            _funcionarioService = new FuncionarioService();
        }

        [Theory]
        [InlineData(280, 20, 56, 336)]
        [InlineData(700, 15, 105, 805)]
        [InlineData(1000, 10, 100, 1100)]
        [InlineData(1501, 5, 75.05, 1576.05)]
        public void ReajusteSalario_DeveCalcularCorretamente(decimal salario, decimal percentual, decimal valoreReajuste, decimal salarioPosReajuste)
        {
            var funcionarioDTO = new FuncionarioDTO { Salario = salario };

            var resultado = _funcionarioService.ReajusteSalario(funcionarioDTO);

            Assert.Equal(salario, resultado.Salario);
            Assert.Equal(percentual, resultado.PercentualAumento);
            Assert.Equal(valoreReajuste, resultado.ValorAumento);
            Assert.Equal(salarioPosReajuste, resultado.SalarioPosReajuste);
        }
    }
}