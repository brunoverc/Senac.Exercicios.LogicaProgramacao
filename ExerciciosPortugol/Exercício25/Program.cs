/*
25) [DESAFIO] Crie um programa que leia o tamanho de três segmentos de reta.
Analise seus comprimentos e diga se é possível formar um triângulo com essas
retas. Matematicamente, para três segmentos formarem um triângulo, o comprimento
de cada lado deve ser menor que a soma dos outros dois.*/

decimal ladoA, ladoB, ladoC;

Console.WriteLine("Digite o comprimento do lado A:");
ladoA = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o comprimento do lado B:");
ladoB = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o comprimento do lado C:");
ladoC = Convert.ToDecimal(Console.ReadLine());

if(ladoA < (ladoB + ladoC) &&
    ladoB < (ladoC + ladoA) &&
    ladoC < (ladoA + ladoB))
{
    Console.WriteLine("É possível formar um triângulo.");
}
else
{
    Console.WriteLine("Não é possível formar um triângulo.");
}