using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {
        //Método simples
        public void Cumplimentar()
        {
            Console.WriteLine("Olá, seja bem-vindo.");
        }

        //Metodos com paramentros

        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine(resultado);
        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos.");
        }

        // passagem de parametros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine($"O valor final é {valor}");
        }


        //passagem de parametros por referencia 

        public void AumentarValorRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine($"O valor final (por referência) é {valor}");
        }

        // metodo com retorno de valores
        public string MontaNome(string nome, string sobrenome)
        {
            //string nomeCompleto = nome + " " + sobrenome;
            return nome + " " + sobrenome;
        }

        public int CodigoChar(char caractere)
        {
            //int codigo = caractere;
            return caractere;
        }

        public double ValorPI()
        {
            return 3.1415;
        }

        // sobrecarga de métodos

        public void Cumplimentar(string nome, int hora)
        {
            string mensagem = hora < 12 ? "Bom dia, " + nome : "Boa tarde, " + nome;
            Console.WriteLine(mensagem);
        }

        public bool Comparar(int num1, int num2)
        {
            return num1 == num2;

        }
    }
}
