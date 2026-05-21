using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models.ApiResponse;
using api.Models.Funcionario;
using api.Models.Funcionario.Dto;
using api.Services.FuncionarioService;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("v1/funcionarios")]
    public class FuncionariosController : ControllerBase
    {
        private readonly IFuncionarioService _funcionarioService;

        public FuncionariosController(IFuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        [HttpPost("reajuste/salario")]
        public ActionResult<ApiResponse<Funcionario>> ReajusteSalario([FromBody] FuncionarioDTO funcionarioDTO)
        {
            var funcionario = _funcionarioService.ReajusteSalario(funcionarioDTO);
            return Ok(ApiResponse<Funcionario>.Ok(funcionario));
        }
    }
}