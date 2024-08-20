/*
64) Crie um programa que leia sexo e peso de 8 pessoas, usando a estrutura
“para”. No final, mostre na tela:
a) Quantas mulheres foram cadastradas
b) Quantos homens pesam mais de 100Kg
c) A média de peso entre as mulheres
d) O maior peso entre os homens
*/

string sexo;
decimal peso, totalPesoMulheres = 0, maiorPesoHomens = 0;
int qtdeMulheres = 0, qtdeHomensMais100Kg = 0;

for(int cont = 1; cont <= 8; cont++)
{
    Console.WriteLine("Digite seu sexo:");
    sexo = Console.ReadLine();
    Console.WriteLine("Digite seu peso:");
    peso = Convert.ToDecimal(Console.ReadLine());

    if(sexo.ToUpper() == "M")
    {
        if(peso > 100)
        {
            qtdeHomensMais100Kg++;
        }

        if(maiorPesoHomens < peso)
        {
            maiorPesoHomens = peso;
        }
    }
    else
    {
        qtdeMulheres++;
        totalPesoMulheres += peso;
    }
}

Console.WriteLine("Quantas mulheres foram cadastradas: " + qtdeMulheres);
Console.WriteLine("Quantos homens pesam mais de 100Kg: " + qtdeHomensMais100Kg);
Console.WriteLine("A média de peso entre as mulheres: " + (totalPesoMulheres / qtdeMulheres));
Console.WriteLine("O maior peso entre os homens: " + maiorPesoHomens);