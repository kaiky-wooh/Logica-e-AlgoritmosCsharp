using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Exercicio de Fixação");

            string nome = Console.ReadLine();
            int quartos = int.Parse(Console.ReadLine());
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split();
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);


            // Saída esperada!
            Console.WriteLine("Você digitou:");

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Quartos: " + quartos);
            Console.WriteLine("Preço do Produto: " + precoProduto.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("último nome: " + ultimoNome + ", Idade " + idade + ", Altura " + altura.ToString(CultureInfo.InvariantCulture)); // Fazer a impressão utilizando o PONTO e não VIRGULA.



            Console.ReadLine();
        }
    }
}