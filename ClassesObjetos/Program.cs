using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Classes e objetos

            MinhaClasse mClasse = new MinhaClasse();
            OutraClasse outraClasse = new OutraClasse();

            #endregion

            #region Atributos de classes

            Pessoa p1 = new Pessoa();
            p1.nome = "Talison";
            p1.sobrenome = "Brisola";
            p1.anoNascimento = 1999;

            Pessoa p2 = new Pessoa()
            {
                nome = "Teste_Nome",
                sobrenome = "Teste_Sobrenome",
                anoNascimento = 2022
            };

            Console.WriteLine($"Pessoa 1: {p1.nome}");
            Console.WriteLine($"Pessoa 1: {p1.sobrenome}");
            Console.WriteLine($"Pessoa 1: {p1.anoNascimento}");
            p1.Cumprimentar();

            Console.WriteLine();

            Console.WriteLine($"Pessoa 2: {p2.nome}");
            Console.WriteLine($"Pessoa 2: {p2.sobrenome}");
            Console.WriteLine($"Pessoa 2: {p2.anoNascimento}");
            p2.Cumprimentar();

            Console.ReadKey();

            #endregion
        }
    }

    class MinhaClasse
    {

    }
}
