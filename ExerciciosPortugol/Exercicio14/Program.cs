/*
 14) A locadora de carros precisa da sua ajuda para cobrar seus serviços. Escreva um
programa que pergunte a quantidade de Km percorridos por um carro alugado e a
quantidade de dias pelos quais ele foi alugado. Calcule o preço total a pagar, sabendo que o
carro custa R$90 por dia e R$0,20 por Km rodado.
 */

int totalKm, totalDias;
decimal valorDia = 90, valorKmRodado = 0.20M, valorTotal;

Console.WriteLine("Digite a quantidade de dias que você ficou com o carro:");
totalDias = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade KM rodados:");
totalKm = Convert.ToInt32(Console.ReadLine());


valorTotal = (totalDias * valorDia) + (totalKm * valorKmRodado);

Console.WriteLine("O valor total da fatura é de: R$ " + valorTotal);