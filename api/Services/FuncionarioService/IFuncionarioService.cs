using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models.Funcionario;
using api.Models.Funcionario.Dto;

namespace api.Services.FuncionarioService
{
    public interface IFuncionarioService
    {
        Funcionario ReajusteSalario(FuncionarioDTO funcionarioDTO);
    }
}