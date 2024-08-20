/*
54) Desenvolva um aplicativo que leia o peso e a altura de 7 pessoas, mostrando
no final:
a) Qual foi a média de altura do grupo
b) Quantas pessoas pesam mais de 90Kg
c) Quantas pessoas que pesam menos de 50Kg e tem menos de 1.60m
d) Quantas pessoas que medem mais de 1.90m pesam mais de 100Kg.
*/

decimal peso = 0, somaAlturas = 0, qtdeMais90Kg = 0, qtdeMenos50KgMenos1_60m = 0,
    qtdeMais1_90mMais100Kg = 0, contador = 0;
int altura = 0;

while(contador < 7)
{
    Console.WriteLine("Digite seu peso:");
    peso = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Digite sua altura (cm):");
    altura = Convert.ToInt32(Console.ReadLine());

    somaAlturas += altura;

    if(peso > 90)
    {
        qtdeMais90Kg++;
    }

    if(peso < 50 && altura < 160)
    {
        qtdeMenos50KgMenos1_60m++;
    }

    if(altura > 190 && peso > 100)
    {
        qtdeMais1_90mMais100Kg++;
    }

    contador++;
}

Console.WriteLine("Qual foi a média de altura do grupo: " + (somaAlturas / 7));
Console.WriteLine("Quantas pessoas pesam mais de 90Kg: " + qtdeMais90Kg);
Console.WriteLine("Quantas pessoas que pesam menos de 50Kg e tem menos de 1.60m: " + qtdeMenos50KgMenos1_60m);
Console.WriteLine("Quantas pessoas que medem mais de 1.90m pesam mais de 100Kg.: " + qtdeMais1_90mMais100Kg);