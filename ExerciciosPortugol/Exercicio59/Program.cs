/*
59) Desenvolva um algoritmo que leia o nome, a idade e o sexo de várias pessoas.
O programa vai perguntar se o usuário quer ou não continuar.

No final, mostre:
a) O nome da pessoa mais velha
b) O nome da mulher mais jovem
c) A média de idade do grupo
d) Quantos homens tem mais de 30 anos
e) Quantas mulheres tem menos de 18 anos
*/

int idade, idadePessoaMaisVelha = 0, idadeMulherMaisJovem = 999, totalIdades = 0, quantidade = 0,
qtdeHomensMais30Anos = 0, qtdeMulheresMenos18Anos = 0;
string continuar = "s", sexo, nome, nomePessoaMaisVelha = "", nomeMulherMaisJovem = "";

while (continuar.ToUpper() == "S")
{
    Console.WriteLine("Digite seu nome:");
    nome = Console.ReadLine();

    Console.WriteLine("Digite seu sexo (M ou F):");
    sexo = Console.ReadLine();

    Console.WriteLine("Diite sua idade:");
    idade = Convert.ToInt32(Console.ReadLine());

    if(idade > idadePessoaMaisVelha)
    {
        nomePessoaMaisVelha = nome;
        idadePessoaMaisVelha = idade;
    }

    if (sexo.ToUpper() == "F")
    {
        if (idade < idadeMulherMaisJovem)
        {
            nomeMulherMaisJovem = nome;
            idadeMulherMaisJovem = idade;
        }

        if(idade < 18)
        {
            qtdeMulheresMenos18Anos++;
        }
    }
    else
    {
        if(idade > 30)
        {
            qtdeHomensMais30Anos++;
        }
    }

    totalIdades += idade;
    quantidade++;

    Console.WriteLine("Deseja continuar informando? (S ou N)");
    continuar = Console.ReadLine();
}

Console.WriteLine("O nome da pessoa mais velha: " + nomePessoaMaisVelha);
Console.WriteLine("O nome da mulher mais jovem: " + nomeMulherMaisJovem);
Console.WriteLine("A média de idade do grupo: " + (totalIdades / quantidade));
Console.WriteLine("Quantos homens tem mais de 30 anos: " + qtdeHomensMais30Anos);
Console.WriteLine("Quantas mulheres tem menos de 18 anos: " + qtdeMulheresMenos18Anos);