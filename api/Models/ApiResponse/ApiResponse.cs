using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models.ApiResponse
{
    public class ApiResponse<T>
    {
        public bool Sucesso { get; set; }
        public T? Dados { get; set; }
        public string? Menssagem { get; set; }
        public List<string>? Erros { get; set; }

        public static ApiResponse<T> Ok(T Dados, string? Mensagem = null)
        {
            return new ApiResponse<T>
            {
                Sucesso = true,
                Dados = Dados,
                Menssagem = Mensagem
            };
        }

        public static ApiResponse<T> BadRequest(string erro)
        {
            return new ApiResponse<T>
            {
                Sucesso = false,
                Erros = new List<string> { erro },
            };
        }

        public static ApiResponse<T> BadRequest(List<string> erros)
        {
            return new ApiResponse<T>
            {
                Sucesso = false,
                Erros = erros,
            };
        }
    }
}