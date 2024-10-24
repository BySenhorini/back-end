// See https://aka.ms/new-console-template for more information
int[] numeros = new int[6];
int qtdPares = 0, qtdImpares = 0;

// Lendo os 6 números inteiros
Console.WriteLine("Digite 6 números inteiros:");
for (int i = 0; i < 6; i++)
{
    Console.Write($"Número {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

// Contando a quantidade de números pares e ímpares
foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        qtdPares++;
    }
    else
    {
        qtdImpares++;
    }
}

// Exibindo os resultados
Console.WriteLine($"\nQuantidade de números pares: {qtdPares}");
Console.WriteLine($"Quantidade de números ímpares: {qtdImpares}");

