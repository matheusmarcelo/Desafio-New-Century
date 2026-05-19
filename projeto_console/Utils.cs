using System.Globalization;

namespace projeto_console
{
    public static class Utils
    {
        public static string FormatarValorPadraoBR(decimal valor)
        {
            return "R$" + valor.ToString("N2", new CultureInfo("pt-BR"));
        }
    }
}