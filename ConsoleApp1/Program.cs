using System;
using System.Globalization;
namespace TesteEGS

{
    class Program
    {
        static void Main(string[] args) {

            Produto produto = new Produto();

            Console.WriteLine("Produtos com 60% de desconto");
                                                    
            Console.Write("Nome do produto: "); // porfavor, digite o nome do produto.
            produto.Nome = Console.ReadLine();
            Console.Write("Preço do produto: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Produto custava: " + produto.Preco.ToString("C", CultureInfo.CurrentCulture)); // testei assim 2834.53, 1999.51, 1002.55 ...
            Console.WriteLine("Com Desconto: " + produto.DescontoProduto().ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Valor do desconto: " + produto.ValorComDesconto().ToString("C", CultureInfo.CurrentCulture));            


        }
    }
}
