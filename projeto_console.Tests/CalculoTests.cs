using projeto_console;

namespace projeto_console.Tests;

public class CalculoTests
{
    [Theory]
    [InlineData(280, 20)]
    [InlineData(281, 15)]
    [InlineData(700, 15)]
    [InlineData(701, 10)]
    [InlineData(1500, 10)]
    [InlineData(1501, 5)]
    public void EscolhePercentual_DeveRetornarPercentualCorreto(decimal salario, int esperado)
    {
        var resultado = Calculo.EscolhePercentual(salario);
        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(1000, 20, 200)]
    [InlineData(1000, 15, 150)]
    [InlineData(1000, 10, 100)]
    [InlineData(1000, 5, 50)]
    public void CalcularValorAumento_DeveRetornarValorCorreto(decimal salario, int percentual, decimal esperado)
    {
        var resultado = Calculo.CalcularValorAumento(salario, percentual);
        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(1000, 100, 1100)]
    [InlineData(280, 56, 336)]
    [InlineData(1501, 75.05, 1576.05)]
    public void CalcularSalario_DeveRetornaAumentoCorreto(decimal salario, decimal aumento, decimal esperado)
    {
        var resultado = Calculo.CalcularSalario(salario, aumento);
        Assert.Equal(esperado, resultado);
    }
}