/*
6) Faça um programa que leia um número inteiro e mostre o seu antecessor e seu sucessor.
Ex:
Digite um número: 9
O antecessor de 9 é 8
O sucessor de 9 é 10*/

int numero;

Console.WriteLine("Digite um número:");
numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("O antecessor de " + numero + " é: " + (numero - 1));
Console.WriteLine("O sucessor de " + numero + " é: " + (numero + 1));

