/*12) Crie um programa que leia o preço de um produto, calcule e mostre o seu
PREÇO PROMOCIONAL, com 5% de desconto.*/

decimal preco, desconto = 0.05M, valorFinal;

Console.WriteLine("Digite o preço do produto:");
preco = Convert.ToDecimal(Console.ReadLine());

valorFinal = preco - desconto * preco;

Console.WriteLine("O valor com desconto é de: R$ " + valorFinal);
