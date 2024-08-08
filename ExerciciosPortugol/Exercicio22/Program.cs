/*
 22) Escreva um programa que leia o ano de nascimento de um rapaz e mostre a sua
situação em relação ao alistamento militar.
- Se estiver antes dos 18 anos, mostre em quantos anos faltam para o
alistamento.
- Se já tiver depois dos 18 anos, mostre quantos anos já se passaram do
alistamento.
 */

int anoNascimento, idade;

Console.WriteLine("Digite o ano do nascimento:");
anoNascimento = Convert.ToInt32(Console.ReadLine());

idade = DateTime.Now.Year - anoNascimento;

if(idade <= 18)
{
    Console.WriteLine("Faltam: " + (18 - idade) + " anos para o alistamento");
}
else
{
    Console.WriteLine("Já se passaram: " + (idade - 18) + " do ano do alistamento");
}