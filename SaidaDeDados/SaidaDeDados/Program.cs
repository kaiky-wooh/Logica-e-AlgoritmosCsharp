using System;
using System.Globalization;

namespace SaidaDeDados;

class Program
{
    static void Main(string[] args)
    {
        // Sem Quebra de Linha
        Console.Write("Olá Mundo");

        // Com quebra de linha
        Console.WriteLine("Bom dia!");

        // Para escreer o conteúdo de uma variável com ponto flutuante

        double x = 10.35784;
        Console.WriteLine(x);

        // Delimitador de casas decimais
        Console.WriteLine(x.ToString("F2")); // 10,36

        Console.WriteLine(x.ToString("F4")); // 10,3578

        // Para escrever com PONTO (.) e NÃO vírgula (,)
        Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

        // Para concatenar vários elementos em um mesmo comando de escrita
        int y = 10;

        double z = 10.38421;

        // Exemplo 1
        Console.WriteLine("Exemplo 1");
        Console.WriteLine("RESULTADO = " + y);

        // Exemplo 2
        Console.WriteLine("Exemplo 2");
        Console.WriteLine("O Valor do troco é " + y + " reais");

        // Exemplo 3 -> Delimitador de casas decimais
        Console.WriteLine("Exemplo 3");
        Console.WriteLine("O valor do troco é " + y.ToString("F2") + " reais");

        // Exemplo 4 -> Delimitador de casas decimais e utilizando o PONTO para separar
        Console.WriteLine("Exemplo 4");
        Console.WriteLine("O Valor do troco é " + z.ToString("F2", CultureInfo.InvariantCulture) + " reais");



        // Retira o "Pressione uma tecla para fechar o programa" no console
        Console.ReadLine();
    }
}