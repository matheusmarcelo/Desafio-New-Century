# Desafio-New-Century
Este projeto é destinado ao desafio da New Century para a vaga de Desenvolvedor.

## Sobre o projeto
Projeto do tipo console criado para calcular o reajuste salarial do funcionário. O sistema recebe o salário atual do funcionário e aplica automaticamente o percentual de aumento correspondente à faixa salarial, exibindo no final um relatório completo do reajuste. 

### Regra de negócio
| Faixa Salarial               | Reajuste |
|------------------------------|----------|
| Até R$ 280,00                |    20%   |
| De R$ 280,01 até R$ 700,00   |    15%   |
| De R$ 700,01 até R$ 1.500,00 |    10%   |
| Acima R$ 1.500,01            |     5%   |

### Relatorio
O relatorio deve informar:

* O salário antes do reajuste;
* O percentual de aumento aplicado;
* O valor do aumento;
* O novo salário, após o reajuste;

# Tools

* dotnet 8.0.204
* C# 12
* xunit 2.5.3
