/*
16) [DESAFIO] Escreva um programa para calcular a redução do tempo de vida de um
fumante. Pergunte a quantidade de cigarros fumados por dias e quantos anos ele
já fumou. Considere que um fumante perde 10 min de vida a cada cigarro. Calcule
quantos dias de vida um fumante perderá e exiba o total em dias.
 */

int anosFumando, quantidadeCigarrosDia, totalDiasPerdidos;

Console.WriteLine("Digite a quantidade de cigarros fumados por dia:");
quantidadeCigarrosDia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantos anos você fuma:");
anosFumando = Convert.ToInt32(Console.ReadLine());

totalDiasPerdidos = (((anosFumando * 365) * quantidadeCigarrosDia) * 10) / 1440;

Console.WriteLine("Você perdeu: " + totalDiasPerdidos + " dias da sua vida.");

