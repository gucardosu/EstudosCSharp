using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Fundamentos_C_.Logica
{
    internal class Ex2
    {
        public static void Executar(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = Double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva seu ultimo nome, idade e altura na mesma linha!");
            string[] array = Console.ReadLine().Split(' ');
            string nome2 = array[0];
            int idade = int.Parse(array[1]);
            double altura = double.Parse(array[2], CultureInfo.InvariantCulture);
            Console.WriteLine(nome2);
            Console.WriteLine(idade + " anos ");
            Console.WriteLine(altura + " cm ");
        }
    }
}
