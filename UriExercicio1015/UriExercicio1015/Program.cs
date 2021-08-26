using System;
using System.Globalization;

/*
 Distância Entre Dois Pontos:

Leia os quatro valores correspondentes aos eixos x e y de dois 
pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância 
entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula:

distancia = √ (x2 - x1)² + (y2 - y1)²

Entrada:
O arquivo de entrada contém duas linhas de dados. A primeira linha contém 
dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores 
de ponto flutuante x2 y2.

Saída:
Calcule e imprima o valor da distância segundo a fórmula 
fornecida, com 4 casas após o ponto decimal.
 */

namespace UriExercicio1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;

            string[] valores;

            valores = Console.ReadLine().Split(' ');
            x1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(valores[1], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            x2 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(valores[1], CultureInfo.InvariantCulture);

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
