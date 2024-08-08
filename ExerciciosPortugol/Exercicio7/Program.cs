/*
 * 7) Crie um algoritmo que leia um número decimal e mostre na tela o seu dobro e a sua terça
parte.
Ex:
Digite um número: 3.5
O dobro de 3.5 é 7.0
A terça parte de 3.5 é 1.16666*/

decimal numero;

Console.WriteLine("Digite um número:");
numero = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("O dobro de " + numero + " é: " + (numero * 2));
Console.WriteLine("A terça parte de " + numero + " é: " + (numero / 3));

