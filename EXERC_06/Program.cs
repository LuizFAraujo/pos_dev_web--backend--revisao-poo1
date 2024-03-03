/*
Adaptar o exercício de validação de CPF da lista 01 em um formato Orientado a Objetos e incluindo validação por RegEX.
*/

using CPF_Utils;

namespace EXERC_06;
class Program
{
    static void Main(string[] args)
    {
        CPF cpf = new CPF();

        InitEnd();

        Console.WriteLine("Informe um número de CPF (somente números ou não):");
        Console.Write("  - CPF:   ");
        cpf.NumCPF = Console.ReadLine() ?? "";

        string[] strResult = { "<< CPF VÁLIDO >>", "<< CPF INVÁLIDO >>" };

        cpf.IsCpfOk = cpf.ValidarCPF(cpf.NumCPF, false);
        string vResult = cpf.IsCpfOk ? strResult[0] : strResult[1];
        Console.WriteLine($"\n • .... Verficação Padrão:  {vResult}");

        cpf.IsCpfOk = cpf.ValidarCPF(cpf.NumCPF);
        vResult = cpf.IsCpfOk ? strResult[0] : strResult[1];
        Console.WriteLine($" • . Verficação por Regex:  {vResult}");

        InitEnd(0);
    }

    static void InitEnd(int? opcao = 1)
    {
        if (opcao == 1)
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                  VALIDAÇÃO DE CPF                   ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("\n");
            return;
        }

        Console.WriteLine("\n\n ----- Pressione uma tecla para sair -----");
        Console.ReadKey();
    }
}