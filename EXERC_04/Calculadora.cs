
namespace Calculadora;

public class Calculadora
{
    public double SomaCalc(double num1, double num2)
    {
        return num1 + num2;
    }

    public double SubtracaoCalc(double num1, double num2)
    {
        return num1 - num2;
    }

    public double MultiplicacaoCalc(double num1, double num2)
    {
        return num1 * num2;
    }

    public double RadiciacaoCalc(double num, int indice)
    {
        if (indice == 2)
            return Math.Sqrt(num);

        return Math.Pow(num, 1.0 / indice);
    }

    public long FatorialCalc(int num)
    {
        if (num == 0 || num == 1)
            return 1;

        return num * FatorialCalc(num - 1);
    }

}
