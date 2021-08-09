using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula45Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do aluno: ");
            string aluno = Console.ReadLine();

            Console.WriteLine("Digite as tres notas do aluno: ");
            Console.Write("Nota 01: ");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 02: ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 03: ");
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = nota1 + nota2 + nota3;
            double valorIdeal = 60.00;

            if(total < valorIdeal)
            {
                Console.WriteLine($"Nota filal = {total.ToString("F2",CultureInfo.InvariantCulture)}");
                Console.WriteLine("Reporvado");
                Console.WriteLine($"Faltam {valorIdeal - total} pontos");
            }
            else
            {
                Console.WriteLine($"Nota filal = {total.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aprovado");
            }
            Console.ReadKey();
        }
    }
}
