using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Pessoa
    {
        //atributos ou campos
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        //metidos simples
        public void Cumprimentar()
        {
            Console.WriteLine($"Olá, eu sou {nome} {sobrenome}" );
            
        }
    }
}
