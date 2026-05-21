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
    public class FuncionarioService
    {
        public Funcionario ReajusteSalario(FuncionarioDTO funcionarioDTO)
        {
            if(funcionarioDTO == null)
            {
                throw new ArgumentException("FuncionarioDTO não pode ser nulo!");
            }

            Funcionario funcionario = new Funcionario();

            if (funcionarioDTO.Salario <= 0)
            {
                throw new ArgumentException("Digite um valor acima de 0!");
            }

            funcionario.Salario = funcionarioDTO.Salario;
            funcionario.PercentualAumento = FuncionarioHelper.EscolhePercentual(funcionario.Salario);
            funcionario.ValorAumento = FuncionarioHelper.CalcularValorAumento(funcionario.Salario, funcionario.PercentualAumento);
            funcionario.SalarioPosReajuste = FuncionarioHelper.CalcularSalario(funcionario.Salario, funcionario.ValorAumento);

            return funcionario;
        }
    }
}