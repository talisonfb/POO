using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Matematica
    {
        public void Somar(int n1, int n2)
        {
            int total = n1 + n2;
            Console.WriteLine($"A soma é {total}");
        }

        public void Subtrair(int n1, int n2)
        {
            int total = n1 - n2;
            Console.WriteLine($"O total é {total}");
        }   

        public void Multiplicar(int n1, int n2)
        {
            int total = n1 * n2;
            Console.WriteLine($"O total é {total}");
        }

        public void Dividir(int n1, int n2)
        {
            int total = n1 / n2;
            Console.WriteLine($"O total é {total}");
        }
    }
}
