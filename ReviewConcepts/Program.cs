// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;

Console.WriteLine(@"
*-------------------------------------------*
 |             Seja Bem-Vindo               |
 --------------------------------------------");

Console.WriteLine("Ola, digite seu nome:");
string nome  = Console.ReadLine();

Console.WriteLine($"Agora digite seu sobrenome: ");
string sobrenome = Console.ReadLine();


//clw



Console.WriteLine("Digite seu endereco:");
string endereco = Console.ReadLine();

Console.WriteLine("Agora, digite seu CPF:");
string CPF = Console.ReadLine();


Console.WriteLine("Me diga o numero do seu telefone:");
string telefone = Console.ReadLine();


Console.WriteLine("Informe a sua idade:");
int idade = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Obrigado: {nome} {sobrenome}");
Console.WriteLine($"Seu endereco e: {endereco}");
Console.WriteLine($"Seu CPF eh: {CPF}");
Console.WriteLine($"Seu telefone e: {telefone}");
Console.WriteLine($"Voce tem: {idade}");