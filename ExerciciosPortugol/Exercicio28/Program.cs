/*
 28) Faça um programa que leia a largura e o comprimento de um terreno
retangular, calculando e mostrando a sua área em m2. O programa também
deve mostrar a classificação desse terreno, de acordo com a lista abaixo:
- Abaixo de 100m2 = TERRENO POPULAR
- Entre 100m2 e 500m2 = TERRENO MASTER
- Acima de 500m2 = TERRENO VIP
*/

decimal largura, comprimento, areaTotal;

Console.WriteLine("Digite a largura do terreno:");
largura = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o comprimento do terreno:");
comprimento = Convert.ToDecimal(Console.ReadLine());

areaTotal = largura * comprimento;
string mensagem = "Área total: " + areaTotal + ".\nClassificação: ";
if(areaTotal < 100)
{
    Console.WriteLine(mensagem + "TERRENO POPULAR");
}
else if(areaTotal <= 500)
{
    Console.WriteLine(mensagem + "TERRENO MASTER");
}
else
{
    Console.WriteLine(mensagem + "TERRENO VIP");
}