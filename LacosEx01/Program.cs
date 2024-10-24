// See https://aka.ms/new-console-template for more information
int qtdMulher = 0;
int qtdHomem = 0;
int qtdEsportes = 0;
Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int qtdDeEntrevistados = int.Parse(Console.ReadLine()!);

for(int i = 1; i <= qtdDeEntrevistados; i++)
{
    Console.WriteLine($"Qual eh o seu sexo? m/f");
    string sexo = Console.ReadLine();

    Console.WriteLine($"Voce gosta de esportes?");
    string esportes = Console.ReadLine();


if(sexo == "f")
{
    qtdMulher++;
}
else{
    qtdHomem++;
}

if (esportes == "nao")
{
   qtdEsportes ++; 
}
}

Console.WriteLine($"Qunatidade de Mulheres: {qtdMulher}");
Console.WriteLine($"Quantidade de Homens: {qtdHomem}");
Console.WriteLine($"Total de Entrevistados: {qtdMulher + qtdHomem}");
Console.WriteLine($"Total de pessoas que nao gostam de esportes: {qtdEsportes}");