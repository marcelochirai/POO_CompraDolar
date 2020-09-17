using System;
using System.Collections.Generic;
using System.Text;

namespace CompraDolar
{
    class Calculo
    {
        public static double cotDolar;
        public static double qtdDolar;
        public static double iof = 6.0;

        public static double ValorCompra()
        {
            double totalDolar = qtdDolar * cotDolar;    //Valor sem IOF
            return totalDolar+totalDolar*iof/100.0;     //Valor com IOF
        }
    }
}
