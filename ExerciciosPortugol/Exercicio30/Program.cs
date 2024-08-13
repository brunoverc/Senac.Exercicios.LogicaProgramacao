/*
 30) [DESAFIO] Refaça o algoritmo 25, acrescentando o recurso de mostrar que tipo
de triângulo será formado:
- EQUILÁTERO: todos os lados iguais
- ISÓSCELES: dois lados iguais
- ESCALENO: todos os lados diferentes
*/

decimal ladoA, ladoB, ladoC;

Console.WriteLine("Digite o comprimento do lado A:");
ladoA = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o comprimento do lado B:");
ladoB = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o comprimento do lado C:");
ladoC = Convert.ToDecimal(Console.ReadLine());

if (ladoA < (ladoB + ladoC) &&
    ladoB < (ladoC + ladoA) &&
    ladoC < (ladoA + ladoB))
{
    if (ladoA == ladoB &&
        ladoB == ladoC)
    {
        Console.WriteLine("É um triângulo EQUILÁTERO, todos os lados são iguais.");
    }
    else if (ladoA != ladoB &&
        ladoB != ladoC &&
        ladoA != ladoC) {
        Console.WriteLine("É um triângulo ESCALENO, todos os lados diferentes.");
    }
    else
    {
        Console.WriteLine("É um triângulo ISÓSCELES: dois lados iguais.");
    }
}
else
{
    Console.WriteLine("Não é possível formar um triângulo.");
}