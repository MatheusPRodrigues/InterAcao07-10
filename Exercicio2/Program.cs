// PAR OU ÍMPAR

Console.Write("Digite um número inteiro: ");
int Numero = int.Parse(Console.ReadLine());

if (Numero % 2 == 0)
    Console.WriteLine($"{Numero} é par!");
else
    Console.WriteLine($"{Numero} é impar!");