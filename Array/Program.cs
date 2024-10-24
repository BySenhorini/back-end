// See https://aka.ms/new-console-template for more information

string[] carros = new string[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Digite o nome do carro a ser cadastrado:");
    carros[i] = Console.ReadLine()!;

}
Console.WriteLine($"");
Console.WriteLine($"O carro cadastradado e {carros[0]}, {carros[1]}, e {carros[2]} ");
Console.WriteLine($"");

