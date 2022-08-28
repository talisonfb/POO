using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            //m.Cumplimentar();
            //m.Somar(10, 5);
            //m.Apresentar("Talison", 22);

            //int valor1 = 100;
            //int valor2 = 100;

            //m.AumentarValor(valor1);
            //m.AumentarValorRef(ref valor2);

            //Console.WriteLine($"v1 {valor1}");
            //Console.WriteLine($"v2 {valor2}");

            string nomeCompleto = m.MontaNome("Talison", "Brisola");
            int codigoChar = m.CodigoChar('T');
            Double pi = m.ValorPI();

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(codigoChar);
            Console.WriteLine(pi);


            Console.ReadKey();
        }

    }
}
