// CÁLCULO DE DESCONTO EM PRODUTO

Console.Write("Digite o valor do produto: ");
double ValorProduto = double.Parse(Console.ReadLine());

Console.Write("Digite a forma de pagamento\n1 - à vista | 2 - parcelado\n: ");
string FormaPagamento = Console.ReadLine();  

if (FormaPagamento == "1")
{
    double ValorFinal = ValorProduto - (ValorProduto * 0.10);
    Console.WriteLine($"Valor a pagar: {ValorFinal:C}");
}
else if (FormaPagamento == "2")
    Console.WriteLine($"Valor a pagar: {ValorProduto:C}");
else
    Console.WriteLine("Opção inválida!");
