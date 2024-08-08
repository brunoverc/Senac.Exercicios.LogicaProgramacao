/*
 5) Faça um programa que leia as duas notas de um aluno em uma matéria e mostre na tela a
sua média na disciplina.
Ex:
Nota 1: 4.5
Nota 2: 8.5
A média entre 4.5 e 8.5 é igual a 6.5*/


decimal nota1, nota2, media;

Console.WriteLine("Digite a primeira nota:");
nota1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");
nota2 = Convert.ToDecimal(Console.ReadLine());

media = (nota1 + nota2) / 2;

Console.WriteLine("A média é: " + media);
