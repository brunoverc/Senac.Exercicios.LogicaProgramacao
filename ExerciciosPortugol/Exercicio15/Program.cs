/*
 15) Crie um programa que leia o número de dias trabalhados em um mês e mostre o
salário de um funcionário, sabendo que ele trabalha 8 horas por dia e ganha R$25
por hora trabalhada.
 */

int diasTrabalhados, horasDoDia = 8;
decimal valorHora = 25, salario;

Console.WriteLine("Digite a quantidade de dias trabalhados no mês:");
diasTrabalhados = Convert.ToInt32(Console.ReadLine());

salario = (diasTrabalhados * horasDoDia) * valorHora;

Console.WriteLine("O salário para o mês é de: R$ " + salario);