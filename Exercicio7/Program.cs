// CLASSIFICAÇÃO DE TRIÂNGULO

double Lado1, Lado2, Lado3;

Console.Write("Digite o primero lado do triângulo: ");
Lado1 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo lado do triângulo: ");
Lado2 = double.Parse(Console.ReadLine());

Console.Write("Digite o terceiro lado do triângulo: ");
Lado3 = double.Parse(Console.ReadLine());

if ((Lado1 < (Lado2 + Lado3)) &&
    (Lado2 < (Lado1 + Lado3)) &&
    (Lado3 < (Lado1 + Lado2)))
{
    if (Lado1 == Lado2 && Lado2 == Lado3)
        Console.WriteLine("Triângulo Equilátero");
    else if (Lado1 == Lado2 || Lado2 == Lado3 || Lado3 == Lado1)
        Console.WriteLine("Triângulo Isósceles");
    else
        Console.WriteLine("Triângulo Escaleno");
}
else
    Console.WriteLine("Não é um triângulo");

Console.WriteLine("Pressione qualquer tecla para sair");
Console.ReadKey();