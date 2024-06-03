using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Funções Matematicas");

            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;
            double delta;

            // Raíz quadrada
            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);
            Console.WriteLine("Raíz quadrada de " + x + " = " + A);
            Console.WriteLine("Raíz quadrada de " + y + " = " + B);
            Console.WriteLine("Raíz quadrada de 25 = " + C );

            // Elevado
            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);
            Console.WriteLine(x + " elevado a " + y + " = " + A);
            Console.WriteLine(x + " elevado ao quadrado = " + B);
            Console.WriteLine("5 elevado ao quadrado = " + C);

            // Valor Absoluto
            A = Math.Abs(y);
            B = Math.Abs(z);
            Console.WriteLine("Valor absoluto de " + y + " = " + A);
            Console.WriteLine("Valor absoluto de " + z + " = " + B);

            // Fórmula de Bhaskara
            // delta = Math.Pow(B, 2.0) - 4 * A * C;
            // x1 = (-b + Math.Sqrt(delta)) / (2.0 *a);
            // x1 = (-b - Math.Sqrt(delta)) / (2.0 *a);
            Console.ReadLine();

        }
    }
}
