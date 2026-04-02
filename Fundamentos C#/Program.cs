using Fundamentos_C_.POO_Classes;
using System.Globalization;

namespace Fundamentos_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Entre com o preço do produto: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine("Digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
