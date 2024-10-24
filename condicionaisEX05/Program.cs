// See https://aka.ms/new-console-template for more information
Console.Write("Digite o número de maçãs compradas: ");
int quantidade = int.Parse(Console.ReadLine());

decimal precoUnitario;

if (quantidade < 12)
{
    precoUnitario = 0.30m;
}
else
{
    precoUnitario = 0.25m;
}

decimal total = quantidade * precoUnitario;

Console.WriteLine($"O valor total da compra é: R$ {total:F2}");

