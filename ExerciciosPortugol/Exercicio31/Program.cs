/*
 31) Crie um jogo de JoKenPo (Pedra-Papel-Tesoura)
 */

string jogada1, jogada2;

Console.WriteLine("Digite sua jogada: Pedra, Papel ou Tesoura");
jogada1 = Console.ReadLine();

Console.WriteLine("Digite sua jogada: Pedra, Papel ou Tesoura");
jogada2 = Console.ReadLine();

int jogadorVencedor = 0;

if(jogada1 == jogada2)
{
    Console.WriteLine("Houve um empate");
    return;
}

if(jogada1.ToLower() == "pedra")
{
    if(jogada2.ToLower() == "tesoura")
    {
        jogadorVencedor = 1;
    }
    else
    {
        jogadorVencedor = 2;
    }
    
}
else if(jogada1.ToLower() == "papel")
{
    if (jogada2.ToLower() == "pedra")
    {
        jogadorVencedor = 1;
    }
    else
    {
        jogadorVencedor = 2;
    }
}
else if(jogada1.ToLower() == "tesoura")
{
    if (jogada2.ToLower() == "papel")
    {
        jogadorVencedor = 1;
    }
    else
    {
        jogadorVencedor = 2;
    }
}

if(jogadorVencedor == 1)
{
    Console.WriteLine("Jogador 1: " + jogada1 + " ganha de Jogador 2: " + jogada2);
}
else
{
    Console.WriteLine("Jogador 2: " + jogada2 + " ganha de Jogador 1: " + jogada1);
}