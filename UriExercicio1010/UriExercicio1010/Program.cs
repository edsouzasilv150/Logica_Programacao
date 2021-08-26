using System;
using System.Globalization;

/*
 Cálculo Simples:

Neste problema, deve-se ler o código de uma peça 1, 
o número de peças 1, o valor unitário de cada peça 1, 
o código de uma peça 2, o número de peças 2 e o valor 
unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

Entrada:
O arquivo de entrada contém duas linhas de dados. 
Em cada linha haverá 3 valores, respectivamente dois 
inteiros e um valor com 2 casas decimais.

Saída:
A saída deverá ser uma mensagem conforme o exemplo 
fornecido abaixo, lembrando de deixar um espaço após 
os dois pontos e um espaço após o "R$". O valor deverá 
ser apresentado com 2 casas após o ponto.
 */
namespace UriExercicio1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codPeca1, numPeca1,codPeca2, numPeca2;
            double valorTotal, valorUnit1, valorUnit2;

            string[] vls = Console.ReadLine().Split(' ');
            codPeca1 = int.Parse(vls[0]);
            numPeca1 = int.Parse(vls[1]);
            valorUnit1 = double.Parse(vls[2], CultureInfo.InvariantCulture);

            vls = Console.ReadLine().Split(' ');
            codPeca2 = int.Parse(vls[0]);
            numPeca2 = int.Parse(vls[1]);
            valorUnit2 = double.Parse(vls[2], CultureInfo.InvariantCulture);

            valorTotal = valorUnit1 * numPeca1 + valorUnit2 * numPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
