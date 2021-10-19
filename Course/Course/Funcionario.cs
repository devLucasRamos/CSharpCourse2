using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            double salarioLiquido = SalarioBruto - Imposto;
            return salarioLiquido;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = ((SalarioBruto * porcentagem) / 100)+SalarioLiquido();
        }
        public override string ToString()
        {
            return "Funcionario: "+Nome+", R$ ";
        }
    }
}
