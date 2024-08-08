/*
 18) Faça um programa que leia o ano de nascimento de uma pessoa, calcule a idade
dela e depois mostre se ela pode ou não votar.
 */

int anoNascimento, idadeMinimaVoto = 16, idade;

Console.WriteLine("Digite seu ano de nascimento: ");
anoNascimento = Convert.ToInt32(Console.ReadLine());

idade = DateTime.Now.Year - anoNascimento;

if(idade > idadeMinimaVoto)
{
    Console.WriteLine("Você pode votar");
}
else
{
    Console.WriteLine("Você não pode votar");
}