using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return (Largura + Altura)*2;
        }
        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }
    }
}
