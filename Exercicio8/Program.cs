// CÁLCULO DE MÉDIA PONDERADA E CONCEITO

Console.Write("Digite a primeira nota: ");
double Nota1 = double.Parse(Console.ReadLine());
Console.Write("Digite o peso da primeira nota: ");
double Peso1 = double.Parse(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
double Nota2 = double.Parse(Console.ReadLine());
Console.Write("Digite o peso da segunda nota: ");
double Peso2 = double.Parse(Console.ReadLine());

Console.Write("Digite a terceira nota: ");
double Nota3 = double.Parse(Console.ReadLine());
Console.Write("Digite o peso da terceira nota: ");
double Peso3 = double.Parse(Console.ReadLine());

double Media = (Nota1 * Peso1) + (Nota2 * Peso2) + (Nota3 * Peso3) / Peso1 + Peso2 + Peso3;

//double Media = 6.99;

if (Media >= 9)
    Console.WriteLine("A");
else if (Media >= 7)
    Console.WriteLine("B");
else if (Media >= 5)
    Console.WriteLine("C");
else
    Console.WriteLine("D");