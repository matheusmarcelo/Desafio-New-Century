using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services.FuncionarioService
{
    public static class FuncionarioUtils
    {
        public static string FormatarValorPadraoBR(decimal valor)
        {
            return "R$" + valor.ToString("N2", new CultureInfo("pt-BR"));
        }
    }
}