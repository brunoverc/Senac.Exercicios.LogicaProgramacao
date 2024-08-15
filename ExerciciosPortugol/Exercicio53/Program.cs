/*
53) Faça um programa que leia a idade e o sexo de 5 pessoas, mostrando no final:
a) Quantos homens foram cadastrados
b) Quantas mulheres foram cadastradas
c) A média de idade do grupo
d) A média de idade dos homens
e) Quantas mulheres tem mais de 20 anos
*/

int contador = 0, idade, qtdeMulheres = 0, qtdeHomens = 0, mediaIdade = 0,
    mediaIdadeHomens = 0, qtdeMulheresMais20 = 0;
string sexo = "";

while(contador < 5)
{
    Console.WriteLine("Digite sua idade:");
    idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite seu sexo:(M ou F)");
    sexo = Console.ReadLine();

    if(sexo.ToUpper() == "F")
    {
        qtdeMulheres++;

        if(idade > 20)
        {
            qtdeMulheresMais20++;
        }
    }
    else
    {
        qtdeHomens++;
        mediaIdadeHomens += idade;
    }

    mediaIdade += idade;

    contador++;
}

Console.WriteLine("Quantos homens foram cadastrados:" + qtdeHomens);
Console.WriteLine("Quantas mulheres foram cadastradas:" + qtdeMulheres);
Console.WriteLine("A média de idade do grupo:" + (mediaIdade / 5));
Console.WriteLine("A média de idade dos homens:" + (mediaIdade / qtdeHomens));
Console.WriteLine("Quantas mulheres tem mais de 20 anos:" + qtdeMulheresMais20);