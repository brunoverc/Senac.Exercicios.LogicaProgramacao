﻿/*
 41) Faça um algoritmo que pergunte ao usuário um número inteiro e positivo
qualquer e mostre uma contagem até esse valor:
Ex: Digite um valor: 35
Contagem: 1 2 3 4 5 6 7 ... 33 34 35 Acabou!
 */

int contador = 1;

Console.WriteLine("Digite um número");
int limite = Convert.ToInt32(Console.ReadLine());

while (contador <= limite)
{
    Console.Write(contador + " ");

    contador++;
}

Console.Write("Acabou!");