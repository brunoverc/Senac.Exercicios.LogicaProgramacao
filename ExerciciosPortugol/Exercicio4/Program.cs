/*
4) Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório entre eles.
Ex:
Digite um valor: 8
Digite outro valor: 5
A soma entre 8 e 5 é igual a 13.*/

int valor1, valor2, resultado;

Console.WriteLine("Digite um valor: ");
valor1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite outro valor:");
valor2 = Convert.ToInt32(Console.ReadLine());

resultado = valor1 + valor2;

Console.WriteLine("A soma entre " + valor1 + " e " + valor2 + " é igual a " + resultado);
