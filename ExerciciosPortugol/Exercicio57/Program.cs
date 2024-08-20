/*
57) Faça um algoritmo que leia a idade de vários alunos de uma turma. O programa
vai parar quando for digitada a idade 999. No final, mostre quantos alunos existem na turma
e qual é a média de idade do grupo.
*/

int idade = 0, totalIdades = 0, qtdeAlunos = 0;

while(idade != 999)
{
    totalIdades += idade;
    qtdeAlunos++;

    Console.WriteLine("Digite sua idade:");
    idade = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("O total de alunos é de: " + qtdeAlunos);
Console.WriteLine("A média de idade na turma é de: " + (totalIdades / qtdeAlunos));