//string Nome; 

//Console.WriteLine("Informe seu nome: ");
//Nome = Console.ReadLine();

//Console.WriteLine("Seja bem vindo " + Nome + "!");
//Console.ReadKey();

float Numero1, Numero2, Resultado;

Console.Write("Digite o primeiro número: ");
Numero1 = float.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
Numero2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Soma: {Numero1} + {Numero2} = {Numero1 + Numero2}");

Console.WriteLine($"Subtração: {Numero1} - {Numero2} = {Numero1 - Numero2}");

Console.WriteLine($"Multiplicação: {Numero1} x {Numero2} = {Numero1 * Numero2}");

if (Numero2 != 0)
    Console.WriteLine($"Divisão: {Numero1} : {Numero2} = {Numero1 / Numero2}");
else
    Console.WriteLine("Divisão pelo número zero não é permitida!");