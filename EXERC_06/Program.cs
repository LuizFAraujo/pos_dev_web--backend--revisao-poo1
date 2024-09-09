using CPF_Utils;

namespace EXERC_06;

class Program
{
    static void Main(string[] args)
    {
        var cpf = new CPF();

        DisplayHeader();

        Console.WriteLine("Informe um número de CPF (somente números ou não):");
        Console.Write("  - CPF:   ");
        cpf.NumCPF = Console.ReadLine() ?? string.Empty;

        var validationMessages = new[]
        {
            "<< CPF VÁLIDO >>",
            "<< CPF INVÁLIDO >>"
        };

        DisplayValidationResult(cpf, validationMessages);

        WaitForExit();
    }

    static void DisplayHeader()
    {
        Console.Clear();
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                  VALIDAÇÃO DE CPF                   ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine();
    }

    static void DisplayValidationResult(CPF cpf, string[] messages)
    {
        bool isValid = cpf.Validate(cpf.NumCPF, false);
        string resultMessage = isValid ? messages[0] : messages[1];
        Console.WriteLine($"\n • Verificação Padrão:  {resultMessage}");

        isValid = cpf.Validate(cpf.NumCPF);
        resultMessage = isValid ? messages[0] : messages[1];
        Console.WriteLine($" • Verificação por Regex:  {resultMessage}");
    }

    static void WaitForExit()
    {
        Console.WriteLine("\n\n ----- Pressione uma tecla para sair -----");
        Console.ReadKey();
    }
}
