/*
 20) Desenvolva um programa que leia um número inteiro e mostre se ele é PAR ou
ÍMPAR.
*/

int numero;

Console.WriteLine("Digite um número:");
numero = Convert.ToInt32(Console.ReadLine());

if(numero % 2 == 0)
{
    Console.WriteLine("Esse número é par");
}
else
{
    Console.WriteLine("Esse número é ímpar");
}