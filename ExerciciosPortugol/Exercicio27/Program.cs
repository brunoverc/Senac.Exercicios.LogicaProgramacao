/*
 27) Crie um programa que leia duas notas de um aluno e calcule a sua média,
mostrando uma mensagem no final, de acordo com a média atingida:
- Média até 4.9: REPROVADO
- Média entre 5.0 e 6.9: RECUPERAÇÃO
- Média 7.0 ou superior: APROVADO
*/

decimal nota1, nota2, media;

Console.WriteLine("Digite a primeira nota:");
nota1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");
nota2 = Convert.ToDecimal(Console.ReadLine());

media = (nota1 + nota2) / 2;

if(media <= 4.9M)
{
    Console.WriteLine("REPROVADO");
}
else if(media <= 6.9M)
{
    Console.WriteLine("RECUPERAÇÃO");
}
else
{
    Console.WriteLine("APROVADO");
}