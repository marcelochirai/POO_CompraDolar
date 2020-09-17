using System;
using System.Globalization;

namespace CompraDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar?  ");
            Calculo.cotDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você irá comprar?  ");
            Calculo.qtdDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em Reais com IOF: " + Calculo.ValorCompra().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
