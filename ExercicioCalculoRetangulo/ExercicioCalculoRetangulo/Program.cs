using System;
using System.Globalization;

/*
 Fazer um programa para ler as medidas da base e altura de um retângulo. Em
seguida, mostrar o valor da área, perímetro e diagonal deste retângulo, com quatro
casas decimais, conforme exemplo.

Entrada: 
5.0
4.0

Saída:
AREA = 20.0000
PERIMETRO = 18.0000
DIAGONAL = 6.4031
 */

namespace ExercicioCalculoRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double bs, altura, area, perimetro, diagonal;

            bs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = bs * altura;
            perimetro = 2 * bs + 2 * altura;
            diagonal = Math.Sqrt(Math.Pow(bs, 2.0) + Math.Pow(altura, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
