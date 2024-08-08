/*
8) Desenvolva um programa que leia uma distância em metros e mostre os valores relativos
em outras medidas.
Ex:
Digite uma distância em metros: 185.72
A distância de 85.7m corresponde a:
0.18572Km
1.8572Hm
18.572Dam
1857.2dm
18572.0cm
185720.0mm*/

decimal km, hm, dam, dm, cm, mm, metros;

Console.WriteLine("Digite a quantidade de metros:");
metros = Convert.ToDecimal(Console.ReadLine());

km = metros * 0.001M;
hm = metros * 0.01M;
dam = metros * 0.1M;
dm = metros * 10;
cm = metros * 100;
mm = metros * 1000;

Console.WriteLine("O valor de metros em Km é: " + km);
Console.WriteLine("O valor de metros em hm é: " + hm);
Console.WriteLine("O valor de metros em dam é: " + dam);
Console.WriteLine("O valor de metros em dm é: " + dm);
Console.WriteLine("O valor de metros em cm é: " + cm);
Console.WriteLine("O valor de metros em mm é: " + mm);
