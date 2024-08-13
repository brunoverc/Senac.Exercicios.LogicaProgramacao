/*
 29) Desenvolva um programa que leia o nome de um funcionário, seu salário,
quantos anos ele trabalha na empresa e mostre seu novo salário, reajustado de
acordo com a tabela a seguir:
- Até 3 anos de empresa: aumento de 3%
- entre 3 e 10 anos: aumento de 12.5%
- 10 anos ou mais: aumento de 20%
 */

string nome;
decimal salario, salarioReajustado;
int anosEmpresa;

Console.WriteLine("Digite seu nome:");
nome = Console.ReadLine();

Console.WriteLine("Digite seu salário atual:");
salario = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quantidade de anos que trabalha na empresa:");
anosEmpresa = Convert.ToInt32(Console.ReadLine());

if(anosEmpresa < 3)
{
    salarioReajustado = salario + (salario * 0.03M);
}
else if(anosEmpresa < 10)
{
    salarioReajustado = salario + (salario * 0.125M);
}
else
{
    salarioReajustado = salario + (salario * 0.2M);
}
Console.WriteLine(nome + " seu novo salário é de: R$ " + salarioReajustado);