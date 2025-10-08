// VERIFICAÇÃO DE MÚLTIPLOS

Console.Write("Digite um número inteiro: ");
int Numero1 = int.Parse(Console.ReadLine());

Console.Write("Digite outro número inteiro: ");
int Numero2 = int.Parse(Console.ReadLine());

if (Numero1 % Numero2 == 0 && Numero2 % Numero1 != 0)
    Console.WriteLine($"{Numero1} é múltiplo de {Numero2}, mas {Numero2} não é múltiplo de {Numero1}");
else if (Numero1 % Numero2 != 0 && Numero2 % Numero1 == 0)
    Console.WriteLine($"{Numero1} não é múltiplo de {Numero2}, mas {Numero2} é múltiplo de {Numero1}");
else if (Numero1 % Numero2 == 0 && Numero2 % Numero1 == 0)
    Console.WriteLine("Ambos números são múltiplos");
else
    Console.WriteLine("Número não são múltiplos");