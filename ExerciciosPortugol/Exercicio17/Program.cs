/*
 17) Escreva um programa que pergunte a velocidade de um carro. Caso ultrapasse
80Km/h, exiba uma mensagem dizendo que o usuário foi multado. Nesse caso, exiba
o valor da multa, cobrando R$5 por cada Km acima da velocidade permitida.
*/

int velocidadeCarro, limiteVelocidade = 80;
decimal valorMulta = 5, valorPagar;

Console.WriteLine("Digite a velocidade do carro:");
velocidadeCarro = Convert.ToInt32(Console.ReadLine());

if(velocidadeCarro > limiteVelocidade)
{
    valorPagar = (velocidadeCarro - limiteVelocidade) * valorMulta;
    Console.WriteLine("Você passou acima do limite permitido, multa: R$ " + valorPagar);
}