/*
Criar um programa que exiba o resultado das operações:
- soma
- subtração
- multiplicação
- radiciação
- fatorial
Com o uso de objetos e métodos.
Para o cálculo do fatorial, procure usar métodos recursivos.
*/

namespace EXERC_04;

using Calculadora;
using Result;
class Program
{
    static void Main(string[] args)
    {
        Calculadora calculadora = new Calculadora();
        ResultData result = new ResultData();

        double num1Soma = 10.5;
        double num2Soma = 5;
        double num1Sub = 42;
        double num2Sub = 17.4;
        double num1Mult = 3;
        double num2Mult = 4.5;
        double num1Rad = 27;
        int num2Rad = 3;
        long numFat = 5;

        result.Soma = calculadora.SomaCalc(num1Soma, num2Soma);
        result.Subtracao = calculadora.SubtracaoCalc(num1Sub, num2Sub);
        result.Multiplicacao = calculadora.MultiplicacaoCalc(num1Mult, num2Mult);
        result.Radiciacao = calculadora.RadiciacaoCalc(num1Rad, num2Rad);
        result.Fatorial = calculadora.FatorialCalc((int)numFat);

        InitEnd();
        Console.WriteLine("               ----- SIMULAÇÃO -----\n");

        Console.WriteLine(" Obs.: para simulação, dados pré atribuídos.\n\n");

        Console.WriteLine($" • .......... SOMA  ->  {num1Soma} + {num2Soma}  =  {result.Soma:F1}");
        Console.WriteLine($" • ..... SUBTRAÇÃO  ->  {num1Sub} - {num2Sub}  =  {result.Subtracao:F1}");
        Console.WriteLine($" • . MULTIPLICAÇÃO  ->  {num1Mult} * {num2Mult}  = {result.Multiplicacao:F1}");
        Console.WriteLine($" • .... RADICIAÇÃO  ->  {num2Rad} √ {num1Rad}  =  {result.Radiciacao:F1}");
        Console.WriteLine($" • ...... FATORIAL  ->  {numFat}!  =  {result.Fatorial}");

        InitEnd(0);
    }

    static void InitEnd(int? opcao = 1)
    {
        if (opcao == 1)
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                     CALCULADORA                     ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("\n");
            return;
        }

        Console.WriteLine("\n\n ----- Pressione uma tecla para sair -----");
        Console.ReadKey();
    }
}

