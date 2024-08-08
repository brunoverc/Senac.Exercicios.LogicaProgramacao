/*
 3) Crie um programa que leia o nome e o salário de um funcionário, mostrando no final uma
mensagem.
Ex:
Nome do Funcionário: Maria do Carmo
Salário: 1850,45
O funcionário Maria do Carmo tem um salário de R$1850,45 em Junho.
 */
string nome;
decimal salario;

Console.WriteLine("Nome do Funcionário:");
nome = Console.ReadLine();

Console.WriteLine("Salário:");
string salarioStr = Console.ReadLine();

//Convertendo uma string em Decimal
salario = Convert.ToDecimal(salarioStr);

Console.WriteLine("O funcionário " + nome + " tem um salário de R$ " + salario + " em Agosto");
