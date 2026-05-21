using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using api.Models.Funcionario.Dto;

namespace projeto_console.Tests
{
    public class FuncionarioDTOTests
    {
        private IList<ValidationResult> Validar(object model)
        {
            var resultados = new List<ValidationResult>();
            var contexto = new ValidationContext(model);
            Validator.TryValidateObject(model, contexto, resultados, validateAllProperties: true);
            return resultados;
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-1000)]
        public void Salario_DeveSerInvalido_QuandoValorMenorOuIgualAZero(decimal salario)
        {
            var funcionarioDTO = new FuncionarioDTO { Salario = salario };

            var resultado = Validar(funcionarioDTO);

            Assert.NotEmpty(resultado);
            Assert.Contains(resultado, x => x.MemberNames.Contains(nameof(FuncionarioDTO.Salario)));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(100)]
        [InlineData(1000)]
        public void Salario_DeveSerValido_QuandoValorMarioQueZero(decimal salario)
        {
            var funcionarioDTO = new FuncionarioDTO { Salario = salario };

            var resultado = Validar(funcionarioDTO);

            Assert.Empty(resultado);
        }

        [Fact]
        public void Salario_DeveRetornarMensagemErro_QuandoSalarioIgualAZero()
        {
            var funcionario = new FuncionarioDTO { Salario = 0 };

            var resultado = Validar(funcionario);

            Assert.Contains(resultado, x => x.ErrorMessage == "Digite um valor acima de 0!");
        }
    }
}