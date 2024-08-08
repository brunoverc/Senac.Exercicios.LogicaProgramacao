/*
 *19) Crie um algoritmo que leia o nome e as duas notas de um aluno, calcule a sua
média e mostre na tela. No final, analise a média e mostre se o aluno teve ou
não um bom aproveitamento (se ficou acima da média 7.0)
 */

string nome;
decimal nota1, nota2, media, bomAproveitamento = 7;

Console.WriteLine("Digite seu nome:");
nome = Console.ReadLine();

Console.WriteLine("Digite a nota 1:");
nota1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a nota 2:");
nota2 = Convert.ToDecimal(Console.ReadLine());

media = (nota1 + nota2) / 2;

if(media < bomAproveitamento)
{
    Console.WriteLine(nome + ", você não obteve um bom aproveitamento");
}
else
{
    Console.WriteLine(nome + ", você obteve um bom aproveitamento");
}