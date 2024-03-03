/*
Criar um programa com Classes e Objetos que tenha um método chamado “contaPrimos( )”.
Este método recebe como parâmetro dois números inteiros positivos, sendo o primeiro menor do que o segundo.
O retorno do método será a quantidade de números primos encontrados do primeiro ao segundo valor informado.
Ex: (‘obj’ é um objeto qualquer a escolha do aluno)
x = obj.contaPrimos(5, 20) → x terá o valor 6, já que de 5 até 20 existem seis números primos.
*/


namespace EXERC_02;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                   CONTAGEM PRIMOS                   ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        ObjQualquer objQualquer = new ObjQualquer();

        Console.WriteLine("\nAbaixo, informe dois números inteiros.");
        objQualquer.Num1 = Utils.ConvertEntradaStringToInt("  - Número <1>:   ");
        objQualquer.Num2 = Utils.ConvertEntradaStringToInt("  - Número <2>:   ");

        if (objQualquer.Num1 > objQualquer.Num2)
        {
            int tmp = objQualquer.Num1;
            objQualquer.Num1 = objQualquer.Num2;
            objQualquer.Num2 = tmp;
        }

        objQualquer.QtdePrimo = Utils_Primos.ContaPrimos(objQualquer.Num1, objQualquer.Num2);


        Console.WriteLine("\n\n*****************************************************");
        Console.WriteLine("Quantidade de número(s) primo(s).");
        Console.WriteLine($" - entre {objQualquer.Num1} e {objQualquer.Num2}  =  " + objQualquer.QtdePrimo);

        Console.WriteLine("\n\n ----- Pressione uma tecla para sair -----");
        Console.ReadKey();
    }
}

