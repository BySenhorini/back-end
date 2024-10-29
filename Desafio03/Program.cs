// See https://aka.ms/new-console-template for more information
Desafio Array

float[] temperaturas = new float[12];

Console.WriteLine("Digite a temperatura média de cada mês do ano:");
for (int i = 0; i < 12; i++)
{
    Console.Write($"Mês {i + 1}: ");
    temperaturas[i] = float.Parse(Console.ReadLine());
}

float maiorTemp = temperaturas[0];
float menorTemp = temperaturas[0];

for (int i = 1; i < 12; i++)
{
    if (temperaturas[i] > maiorTemp)
        maiorTemp = temperaturas[i];
    if (temperaturas[i] < menorTemp)
        menorTemp = temperaturas[i];
}

Console.WriteLine($"Maior temperatura do ano: {maiorTemp}°C");
Console.WriteLine($"Menor temperatura do ano: {menorTemp}°C");

