/*9) Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$)
e mostre quantos dólares ela pode comprar. Considere US$1,00 = R$5,66.*/

decimal valorReal, valorDolar, cambioDolar = 5.66M;

Console.WriteLine("Digite o valor em carteira em R$:");
valorReal = Convert.ToDecimal(Console.ReadLine());

valorDolar = valorReal / cambioDolar;

Console.WriteLine("Você pode comprar $ " + valorDolar);