/*10) 
 * Faça um algoritmo que leia a largura e altura de uma parede, calcule e
mostre a área a ser pintada e a quantidade de tinta necessária para o serviço,
sabendo que cada litro de tinta pinta uma área de 2metros quadrados.*/

decimal largura, altura, areaTotal;
int tamanhoAreaPintadaLt = 2;

Console.WriteLine("Digite a largura da parede:");
largura = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a altura da parede");
altura = Convert.ToDecimal(Console.ReadLine());

areaTotal = largura * altura;

Console.WriteLine("Serão necessáros: " + (areaTotal / tamanhoAreaPintadaLt) + 
    " litros de tinta");