using System;
using System.Globalization;

namespace EntradaDeDados2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ler um número inteiro
            int n1 = int.Parse(Console.ReadLine());
            

            // Ler um caractere
            char ch = char.Parse(Console.ReadLine());

            // Ler um número double
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();

        }
    }
}