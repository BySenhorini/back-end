// See https://aka.ms/new-console-template for more information
float salario;
float total;

Console.WriteLine("Olá, digite um salario:");
salario = float.Parse(Console.ReadLine()!);
Console.WriteLine("");


Console.WriteLine("Olá, me informe o total:");
total = float.Parse(Console.ReadLine()!);
Console.WriteLine("");

if(salario >= total){
    Console.WriteLine(@"
    *--------------------*
    | Parabens, querido! |
    *--------------------*");
}

else{
    Console.WriteLine(@"
    *-------------------*
    | nao foi dessa vez |
    *-------------------*");
}