using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new(nome, preco, quantidade);

            Console.WriteLine(p);
            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque: ");
            int adicionar = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.AdicionarProdutos(adicionar);
            Console.WriteLine(p);
            Console.WriteLine("Digite o numero de produtos a ser removido do estoque: ");
            int remover = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.RemoverProdutos(remover);
            Console.WriteLine(p);
        }
    }
}
