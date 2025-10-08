// MAIOR - MENOR - OU IGUAL

Console.Write("Digite um número: ");
double Numero1 = double.Parse(Console.ReadLine());

Console.Write("Digite outro número: ");
double Numero2 = double.Parse(Console.ReadLine());

if (Numero1 > Numero2)
    Console.WriteLine($"{Numero1} é maior que {Numero2}");
else if (Numero1 < Numero2)
    Console.WriteLine($"{Numero1} é menor que {Numero2}");
else
    Console.WriteLine($"{Numero1} é igual a {Numero2}");