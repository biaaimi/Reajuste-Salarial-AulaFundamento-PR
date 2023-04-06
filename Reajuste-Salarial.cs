using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReajusteSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Double Salario;

            Console.WriteLine("informe seu salário: ");
            Console.WriteLine();
            Console.WriteLine("Salario: ");

            double.TryParse(Console.ReadLine(), out Salario);

            Console.WriteLine();

            Console.WriteLine("Salário Atual: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(Salario.ToString());

            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Novo salário: ");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write(p.CalculaSalario(Salario));

            Console.ReadKey();
        }
        private double CalculaSalario(double Salario)
        {
            double NovoSalario = 0;

            if (Salario >= 1700) {
                NovoSalario = (Salario + 200);
            }
            else
            {
                NovoSalario = (Salario + 300);
            }

            return NovoSalario;

        }
    }
}










    

