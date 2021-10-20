using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class ConversorDeMoeda
    {
        public static double cotacao;
        public static double quantidade;

        public static double Conversor(double cotacao,double quantidade)
        {
            return cotacao * quantidade;
        }

    }
}
