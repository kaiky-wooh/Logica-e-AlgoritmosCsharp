using System;
using System.Globalization;

namespace DesafioEntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            -------------DESAFIO--------------
            
            Ler um nome (única palavra), 
            sexo (caractere F ou M), 
            idade (inteiro) e altura (double) na mesma linha 
            armazenando-os em quatro variáveis com os devidos tipos
            */

            string[] dsf = Console.ReadLine().Split(' ');

            // Armazenar os dados digitados no console

            string p1 = dsf[0];
            char p2 = char.Parse(dsf[1]);
            int p3 = int.Parse(dsf[2]);
            double p4 = double.Parse(dsf[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Nome: " + p1 + " Sexo: " + p2 + " Idade: " + p3 + " Altura: " + p4.ToString(CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}