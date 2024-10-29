// See https://aka.ms/new-console-template for more information


int[] vetor01 = new int[10];
int[] vetor02 = new int[10];
int[] vetorIntercalado = new int[20];  


Console.WriteLine("Por favor, digite 10 números para o primeiro vetor:");
for (int i = 0; i < 10; i++)
{
    Console.Write($"Vetor 01 - Elemento {i + 1}: ");
    vetor01[i] = int.Parse(Console.ReadLine());
}


Console.WriteLine("Agora, novamente, digite 10 números para o segundo vetor:");
for (int i = 0; i < 10; i++)
{
    Console.Write($"Vetor 02 - Elemento {i + 1}: ");
    vetor02[i] = int.Parse(Console.ReadLine());
}


for (int i = 0, j = 0; i < 10; i++, j += 2)
{
    vetorIntercalado[j] = vetor01[i];      
    vetorIntercalado[j + 1] = vetor02[i]; 
}


Console.WriteLine("Vetor intercalado:");
foreach (int num in vetorIntercalado)
{
    Console.Write(num + " ");
}