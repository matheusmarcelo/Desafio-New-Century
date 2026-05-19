namespace projeto_console
{
    public static class Calculo
    {
        private const int PERCENTUAL_20 = 20;
        private const int PERCENTUAL_15 = 15;
        private const int PERCENTUAL_10 = 10;
        private const int PERCENTUAL_5 = 5;

        private const decimal SALARIO_280 = 280m;
        private const decimal SALARIO_700 = 700m;
        private const decimal SALARIO_1500 = 1500m;

        public static int EscolhePercentual(decimal salario)
        {
            var percentual = salario switch
            {
                <= SALARIO_280 => PERCENTUAL_20,
                > SALARIO_280 and <= SALARIO_700 => PERCENTUAL_15,
                > SALARIO_700 and <= SALARIO_1500 => PERCENTUAL_10,
                _ => PERCENTUAL_5,
            };

            return percentual;
        }

        public static decimal CalcularValorAumento(decimal salario, decimal percentual)
        {
            return salario * percentual / 100;
        }

        public static decimal CalcularSalario(decimal salario, decimal aumento)
        {
            return salario + aumento;
        }
    }
}