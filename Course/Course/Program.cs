
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.AreaDoTriangulo();
            double areaY = y.AreaDoTriangulo();

            Console.WriteLine("A area de X: " + areaX);

            Console.WriteLine("A area de Y: " + areaY);

            Pessoa a, b;
            a = new Pessoa
            {
                Nome = "Maria",
                Idade = 17
            };
            b = new Pessoa
            {
                Nome = "Joao",
                Idade = 16
            };

            if (a.Idade > b.Idade)
            {
                Console.WriteLine(a.Nome + " é a pessoa mais velha");
            }
            else
            {
                Console.WriteLine(b.Nome + " é a pessoa mais velha");
            }

            FuncionarioSalario ana, carlos;
            carlos = new FuncionarioSalario();
            ana = new FuncionarioSalario();
            carlos.Nome = "Carlos Silva";
            carlos.Salario = 6300;
            ana.Nome = "Ana Marques";
            ana.Salario = 6700;

            int mediaSalario = (carlos.Salario + ana.Salario) / 2;
            Console.WriteLine("Salario medio de " + carlos.Nome + " e " + ana.Nome + " é: " + mediaSalario);


            Produto p = new();

            Console.WriteLine("Entre com os dados do Produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine(p);
            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque: ");
            int adicionar = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.AdicionarProdutos(adicionar);
            Console.WriteLine(p);
            Console.WriteLine("Digite o numero de produtos a ser removido do estoque: ");
            int remover = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.RemoverProdutos(remover);
            Console.WriteLine(p);

            Retangulo r = new();

            Console.WriteLine("Entre com a largura e altura do Retangulo:");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("A Area desse retangulo é " + r.Area());
            Console.WriteLine("O Perimetro desse retangulo é " + r.Perimetro());
            Console.WriteLine("A Diagonal desse retangulo é " + r.Diagonal());

            Funcionario f1 = new()
            {
                Nome = "Joao Silva",
                SalarioBruto = 6000,
                Imposto = 1000
            };
            double salarioLiquido = f1.SalarioLiquido();
            Console.WriteLine(f1 + salarioLiquido.ToString());
            Console.Write("Digite a porcentagem para aumentar o salario: ");
            f1.AumentarSalario(double.Parse(Console.ReadLine()));
            Console.WriteLine(f1 + f1.SalarioBruto.ToString());


            Aluno aluno = new();

            Console.WriteLine("Entre com o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Entre com a primeira nota: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a segunda nota: ");
            aluno.Nota2 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a terceira nota: ");
            aluno.Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("NOTA FINAL: " + aluno.NotaFinal());
            Console.WriteLine(aluno.Situacao());
        }
    }
}