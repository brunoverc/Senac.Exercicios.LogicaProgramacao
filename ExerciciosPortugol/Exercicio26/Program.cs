/*
 26) Escreva um algoritmo que leia dois números inteiros e compare-os, mostrando
na tela uma das mensagens abaixo:
- O primeiro valor é o maior
- O segundo valor é o maior
- Não existe valor maior, os dois são iguais
 */

int primeiroValor, segundoValor;

Console.WriteLine("Digite o primeiro número:");
primeiroValor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
segundoValor = Convert.ToInt32(Console.ReadLine());

if(primeiroValor > segundoValor)
{
    Console.WriteLine("O primeiro valor é o maior");
}
else if(primeiroValor < segundoValor)
{
    Console.WriteLine("O segundo valor é o maior");
}
else
{
    Console.WriteLine("Não existe valor maior, os dois são iguais");
}