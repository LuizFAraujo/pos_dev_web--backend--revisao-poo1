/*
 Criar um programa que receba duas datas e exiba o número de dias de diferença entre elas.
Resolver utilizando Classes e objetos, passando as datas como parâmetros.
Verificar na linguagem escolhida se há um método, função ou API específica para datas.
*/

using DataUtil;

namespace EXERC_05;
class Program
{
    static void Main(string[] args)
    {
        DataObj dataObj = new DataObj();

        InitEnd();

        Console.WriteLine(" Informe duas datas, em qualquer ordem.");
        Console.WriteLine(" Utilize o formado dd/mm/aaaa.\n");

        Console.Write(" • DATA 1 :  ");
        dataObj.Data1 = LerData();
        Console.Write(" • DATA 2 :  ");
        dataObj.Data2 = LerData();

        dataObj.DiferencaDias = dataObj.CalcDiasDif_DuasDatas(dataObj.Data1, dataObj.Data2);
        Console.WriteLine($"\n {dataObj.ToString()}");

        InitEnd(0);
    }

    static DateTime LerData()
    {
        while (true)
        {
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dt))
                return dt;

            Console.WriteLine("Formato de data inválido. Digite novamente:");
        }
    }

    static void InitEnd(int? opcao = 1)
    {
        if (opcao == 1)
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("                   DIFERENÇA DATAS                   ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("\n");
            return;
        }

        Console.WriteLine("\n\n ----- Pressione uma tecla para sair -----");
        Console.ReadKey();
    }
}




