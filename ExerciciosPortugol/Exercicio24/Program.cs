/*
24) Faça um algoritmo que pergunte a distância que um passageiro deseja
percorrer em Km. Calcule o preço da passagem, cobrando R$0.50 por Km para
viagens até 200Km e R$0.45 para viagens mais longas.*/

int distancia;
decimal valorTotal;

Console.WriteLine("Digite a distância a percorrer:");
distancia = Convert.ToInt32(Console.ReadLine());

if(distancia <= 200)
{
    valorTotal = distancia * 0.50M;
}
else
{
    valorTotal = distancia * 0.45M;
}

Console.WriteLine("O valor total a pagar é de: R$ " + valorTotal);