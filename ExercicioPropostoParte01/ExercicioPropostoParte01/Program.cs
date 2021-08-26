using System;
using System.Globalization;

/*
Fazer um programa para ler as medidas da largura e comprimento de um terreno 
retangular com uma casa decimal, bem como o valor do metro quadrado do 
terreno com duas casas decimais. Em seguida, o programa deve mostrar o valor 
da área do terreno, bem como o valor do preço do terreno, ambos com duas 
casas decimais, conforme exemplo.

Ex: Valores de entrada:
Largura = 10.0;
Comprimento = 30.0;
Preço por metro quadrado = 200.00

Valores de Saída:
AREA = 300.00;
PRECO = 6000,00;
 */

namespace ExercicioPropostoParte01
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, preco;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
