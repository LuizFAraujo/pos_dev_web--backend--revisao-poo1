/*
Criar um programa de cadastro de Clientes com nome, endereço, Cep e CPF.
Utilizar os recursos de Classes e objetos.
Encapsular todos os atributos para que possam ser alterados e lidos apenas utilizando métodos de acesso.
Para cada cliente informado, exibir os dados na tela ao final da inserção de dados.
Realizar a validação dos dados usando RegEX.
*/

namespace EXERC_01;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                  CADASTRO CLIENTE                   ");
        Console.WriteLine("                VALIDAÇÃO CPF / REGEX                ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");


        Cliente cliente = new Cliente();

        try
        {
            Console.WriteLine("\nInforme os dados abaixo.");
            Console.WriteLine("(Obs.: CPF com pontos e traço.))\n");

            Console.Write("  -     Nome:   ");
            cliente.Nome = Console.ReadLine() ?? "";

            Console.Write("  - Endereço:   ");
            cliente.Endereco = Console.ReadLine() ?? "";

            Console.Write("  -      CEP:   ");
            cliente.CEP = Console.ReadLine() ?? "";

            Console.Write("  -      CPF:   ");
            cliente.CPF = Console.ReadLine() ?? "";


            Console.WriteLine("\n\n*****************************************************");
            Console.WriteLine("Dados do Cliente:");
            cliente.ExibirDados();
        }
        catch (ArgumentException ex)
        {
         Console.WriteLine("\n\n*****************************************************");
            Console.WriteLine($"              Erro: {ex.Message}");
             Console.WriteLine("*****************************************************");
        }

        Console.WriteLine("\n\n ----- Pressione uma tecla para sair -----");
        Console.ReadKey();
    }
}
