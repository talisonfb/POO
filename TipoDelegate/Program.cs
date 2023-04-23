using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Program
    {
        delegate void Operacao(int num1, int num2);

        static void Main(string[] args)
        {
            Matematica m = new Matematica();

            Operacao conta = null;

            conta += m.Multiplicar;
            conta += m.Somar;
            conta += m.Dividir;
            conta += m.Subtrair;

            conta(10, 2);

        }
    }
}
