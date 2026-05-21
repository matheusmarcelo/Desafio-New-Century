using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly FuncionarioService _funcionarioService;

        public FuncionariosController(FuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        [HttpPost("reajuste/salario")]
        public ActionResult<Funcionario> ReajusteSalario([FromBody] FuncionarioDTO funcionarioDTO)
        {
            try
            {
                var funcionario = _funcionarioService.ReajusteSalario(funcionarioDTO);
                return Ok(funcionario);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}