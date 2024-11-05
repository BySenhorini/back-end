// See https://aka.ms/new-console-template for more information
string frutas = ("Melancias", "Carambola", "Maracuja", "Morango", "Limao");

Console.WriteLine($"Sua sacola contem {frutas.Length} frutas!");

foreach (string f in frutas)

{
    Console.WriteLine(f);
}