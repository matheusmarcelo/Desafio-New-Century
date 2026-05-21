using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using api.Models.Funcionario;
using api.Models.Funcionario.Dto;

namespace api.Services.FuncionarioService
{
    public class FuncionarioService : IFuncionarioService
    {
        public Funcionario ReajusteSalario(FuncionarioDTO funcionarioDTO)
        {
            Funcionario funcionario = new Funcionario
            {
                Salario = funcionarioDTO.Salario
            };

            funcionario.PercentualAumento = FuncionarioHelper.EscolhePercentual(funcionario.Salario);
            funcionario.ValorAumento = FuncionarioHelper.CalcularValorAumento(funcionario.Salario, funcionario.PercentualAumento);
            funcionario.SalarioPosReajuste = FuncionarioHelper.CalcularSalario(funcionario.Salario, funcionario.ValorAumento);

            return funcionario;
        }
    }
}