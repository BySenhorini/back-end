// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int totalHomens = 0;
        int totalMulheres = 0;
        int somaIdadeHomens = 0;
        int somaIdadeMulheres = 0;
        const int totalPessoas = 10;

        for (int i = 0; i < totalPessoas; i++)
        {
            Console.WriteLine($"Pessoa {i + 1}:");

            Console.Write("Informe a idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Informe o peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe o sexo (M/F): ");
            char sexo = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            // Processando a entrada
            if (sexo == 'M')
            {
                totalHomens++;
                somaIdadeHomens += idade;
            }
            else if (sexo == 'F')
            {
                totalMulheres++;
                somaIdadeMulheres += idade;
            }
            else
            {
                Console.WriteLine("Sexo inválido, por favor digite 'M' ou 'F'.");
                i--; // Decrementa o contador para repetir a iteração
                continue;
            }
        }

        // Cálculo das médias
        double mediaIdadeHomens = totalHomens > 0 ? (double)somaIdadeHomens / totalHomens : 0;
        double mediaIdadeMulheres = totalMulheres > 0 ? (double)somaIdadeMulheres / totalMulheres : 0;

        // Exibindo os resultados
        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Total de Homens: {totalHomens}");
        Console.WriteLine($"Total de Mulheres: {totalMulheres}");
        Console.WriteLine($"Média de idade dos Homens: {mediaIdadeHomens:F2}");
        Console.WriteLine($"Média de idade das Mulheres: {mediaIdadeMulheres:F2}");
    }
}