/*
62) Escreva um programa que leia um número qualquer e mostre a tabuada desse
número, usando a estrutura “para”.
Ex: Digite um valor: 5
5 x 1 = 5
5 x 2 = 10
5 x 3 = 15 ...
*/

int multiplicando;

Console.WriteLine("Digite um número da tabuada:");
multiplicando = Convert.ToInt32(Console.ReadLine());

for(int contador = 1; contador <= 10; contador++)
{
    Console.WriteLine(multiplicando + " x " + contador + " = " + (multiplicando * contador));
}