using System.Globalization;

namespace FourteenthPerformance_FirstWithClass_
{
    class Worker
    {
        public string nome;
        public double salarioBruto;
        public double desconto;
        public double aumento;
        public double salarioAtual;

        public double Salario()
        {
            return salarioBruto;
        }
        public void SalarioLiquido(double desconto)
        {
            salarioAtual = salarioBruto - desconto;
        }

        public void NovoSalario(double aumento)
        {
            salarioAtual = salarioBruto + aumento;
        }

        public override string ToString()
        {
            return nome +
                ", R$ " +
                salarioAtual.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
