/*
 2) Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boas
vindas para ela:
Ex:
Qual é o seu nome? João da Silva
Olá João da Silva, é um prazer te conhecer!
*/

string nome;

Console.WriteLine("Qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Olá " + nome + ", é um prazer te conhecer!");
