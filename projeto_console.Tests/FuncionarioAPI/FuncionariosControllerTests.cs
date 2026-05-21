using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using api.Services.FuncionarioService;
using api.Controllers;
using api.Models.Funcionario.Dto;
using FuncionarioModel = api.Models.Funcionario.Funcionario;
using Microsoft.AspNetCore.Mvc;
using api.Models.ApiResponse;

namespace projeto_console.Tests
{
    public class FuncionariosControllerTests
    {
        private readonly Mock<IFuncionarioService> _funcionariServiceMock;
        private readonly FuncionariosController _funcionariosController;

        public FuncionariosControllerTests()
        {
            _funcionariServiceMock = new Mock<IFuncionarioService>();
            _funcionariosController = new FuncionariosController(_funcionariServiceMock.Object);
        }


        [Fact]
        public void ReajusteSalario_DeveRetornarSucessoTrue()
        {
            var funcionarioDTO = new FuncionarioDTO { Salario = 1000 };
            var model = new FuncionarioModel
            {
                Salario = 1000,
                PercentualAumento = 10,
                ValorAumento = 100,
                SalarioPosReajuste = 1100
            };

            _funcionariServiceMock.Setup(x => x.ReajusteSalario(funcionarioDTO)).Returns(model);

            var resultado = _funcionariosController.ReajusteSalario(funcionarioDTO);
            var ok = Assert.IsType<OkObjectResult>(resultado.Result);
            var apiResponse = Assert.IsType<ApiResponse<FuncionarioModel>>(ok.Value);

            Assert.True(apiResponse.Sucesso);
            Assert.Equal(model, apiResponse.Dados);
        }
    }
}