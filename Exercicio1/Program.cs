// MÉDIA DE NOTAS

double Nota1, Nota2, Nota3, Media;

Console.Write("Digite a primeira nota: ");
Nota1 = double.Parse(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
Nota2 = double.Parse(Console.ReadLine());

Console.Write("Digite a terceira nota: ");
Nota3 = double.Parse(Console.ReadLine());

Media = (Nota1 + Nota2 + Nota3) / 3;

if (Media >= 7)
    Console.WriteLine("Aprovado");
else
    Console.WriteLine("Reprovado");