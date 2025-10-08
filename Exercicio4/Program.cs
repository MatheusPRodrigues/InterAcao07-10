// CÁLCULO DE IMC

Console.Write("Digite o seu peso: ");
double Peso = double.Parse(Console.ReadLine());

Console.Write("Digite a sua altura: ");
double Altura = double.Parse(Console.ReadLine());

double Imc = Peso / Math.Pow(Altura, 2);

//double Imc = 24.9;

if (Imc < 18.5)
    Console.WriteLine("Abaixo do peso");
else if (Imc < 25)
    Console.WriteLine("Peso normal");
else if (Imc < 30)
    Console.WriteLine("Sobrepeso");
else
    Console.WriteLine("Obesidade");