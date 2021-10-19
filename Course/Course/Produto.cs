using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }
        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }

        public override string ToString()
        {
            return "Dados do produto: " +
                Nome +
                ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", " + Quantidade.ToString() +
                " unidades, Total: R$ " +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
