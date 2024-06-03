using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        /* Desáfio 
         - Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma casa decimal
         - Calcular o valor do metro quadrado do terreno com duas casas decimais
         - O programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno
         - Ambos com duas casas decimais.
         */

        double largura = double.Parse(Console.ReadLine());
        double comprimento = double.Parse(Console.ReadLine());
        double preco = double.Parse(Console.ReadLine());
        double area = largura * comprimento;
        preco = area * preco;

        Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));


        Console.ReadLine();

    }
}