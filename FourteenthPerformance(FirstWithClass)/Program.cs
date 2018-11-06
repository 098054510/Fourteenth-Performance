using System;
using System.Globalization;

namespace FourteenthPerformance_FirstWithClass_
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker W;
            double desconto, aumento;

            W = new Worker();

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("---------------------------SALAROMETRO 2018----------------------------");
            Console.WriteLine("-----------------------------------------------------------------------");

            Console.WriteLine("Siga os passos descritos e tudo ficará bem");
            Console.WriteLine("Caso não queira aumentar ou descontar, insira '0.00' e tudo ficará bem.");
            Console.WriteLine("Digite o Nome do Funcionario: ");
            W.nome = Console.ReadLine();
            Console.WriteLine("Digite o Salario do Funcionado: ");
            W.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Descontar salario em quanto?: ");
            desconto = double.Parse(Console.ReadLine());
            W.SalarioLiquido(desconto);

            Console.WriteLine("Dados do funcionario: " + W);
            Console.WriteLine("Pressione ENTER Para continuar");
            Console.ReadLine();

            Console.WriteLine("Aumentar salario em quanto?: "); Console.WriteLine("Insira '0.00' caso nao queira aumentar o salario.");
            aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            W.NovoSalario(aumento);

            Console.WriteLine("Dados do funcionario: " + W);
            Console.WriteLine("Pressione ENTER para finalizar");
            Console.ReadLine();
        }
    }
}
