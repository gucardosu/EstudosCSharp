using Fundamentos_C_.POO_Classes;
using System.Globalization;

namespace Fundamentos_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Digite seu nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Digite seu salario bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quanto de imposto tem?: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + funcionario);

            Console.Write("Deseja aumentar o salario em qual porcentagem? ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + funcionario);

        }
    }
}
