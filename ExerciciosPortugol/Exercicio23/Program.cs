/*
 23) Numa promoção exclusiva para o Dia da Mulher, uma loja quer dar descontos
para todos, mas especialmente para mulheres. Faça um programa que leia nome,
sexo e o valor das compras do cliente e calcule o preço com desconto. Sabendo
que:
- Homens ganham 5% de desconto
- Mulheres ganham 13% de desconto*/

string nome, sexo;
decimal valorCompras, percentualDescontoHomem = 0.05M, percentualDescontoMulher = 0.13M;

Console.WriteLine("Escreva seu nome:");
nome = Console.ReadLine();

Console.WriteLine("Digite seu sexo: M ou F");
sexo = Console.ReadLine();

Console.WriteLine("Digite o total das compras:");
valorCompras = Convert.ToDecimal(Console.ReadLine());

if(sexo.ToUpper() == "F")
{
    Console.WriteLine("O valor do desconto é de: R$ " + 
        (valorCompras * percentualDescontoMulher));
}
else
{
    Console.WriteLine("O valor do desconto é de: R$ " +
        (valorCompras * percentualDescontoHomem));
}