using System.Globalization;

namespace projeto_console.Funcionario
{
    public class Funcionario
    {
        private decimal Salario { get; set; }

        public void ExibeValor(decimal valor, string? texto = null)
        {
            if (string.IsNullOrEmpty(texto))
            {
                Console.WriteLine(Utils.FormatarValorPadraoBR(valor));
                return;
            }

            Console.WriteLine(texto + Utils.FormatarValorPadraoBR(valor));
        }

        public void ExibirPercentual(int Percentual)
        {
            Console.WriteLine("Percentual: " + Percentual + "%");
        }

        public void Orquestrador()
        {
            decimal salarioAntesDoCalculo = 0;

            while (true)
            {
                Console.Write("Digite o salario do funcionario: ");
                bool isNumero = decimal.TryParse(Console.ReadLine(), new CultureInfo("pt-BR"), out salarioAntesDoCalculo);

                if (!isNumero)
                {
                    Console.WriteLine("Digite um valor válido!");
                    continue;
                }

                if (salarioAntesDoCalculo <= 0)
                {
                    Console.WriteLine("Digite um valor acima de 0!");
                    continue;
                }

                break;
            }

            Salario = salarioAntesDoCalculo;
            var percentual = Calculo.EscolhePercentual(Salario);
            var valorAumento = Calculo.CalcularValorAumento(Salario, percentual);
            Salario = Calculo.CalcularSalario(Salario, valorAumento);

            // exibe salario antes do aumento
            ExibeValor(salarioAntesDoCalculo, "Salario antes do reajuste: ");

            // exibe percentual
            ExibirPercentual(percentual);

            // exibe valor do aumento
            ExibeValor(valorAumento, "Valor do reajuste: ");

            // exibe salario após reajuste
            ExibeValor(Salario, "Valor após reajuste: ");
        }
    }
}