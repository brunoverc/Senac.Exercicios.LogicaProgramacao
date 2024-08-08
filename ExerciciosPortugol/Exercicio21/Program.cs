/*
 21) Faça um algoritmo que leia um determinado ano e mostre se ele é ou não
BISSEXTO.

(ano mod 400 = 0) ou ((ano mod 4 = 0) e (ano mod 100 <> 0))
*/

int ano;

Console.WriteLine("Digite o ano:");
ano = Convert.ToInt32(Console.ReadLine());

if((ano % 400 == 0) || ((ano % 4 == 0) && (ano % 100 != 0)))
{
    Console.WriteLine("O ano é Bissexto");
}
else
{
    Console.WriteLine("O ano não é Bissexto");
}