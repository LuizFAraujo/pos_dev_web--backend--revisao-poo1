/*
Utilizando o recurso de sobrecarga de métodos, crie um programa com uma Classe que contenha um método chamado “calcular( )”.
O comportamento deste método muda de acordo com o parâmetro informado:
- Retorna a área do círculo caso receba um valor do tipo double;
- Retorna a área do quadrado caso receba dois valores do tipo double;
- Retorna o perímetro de um triângulo caso receba três valores do tipo int;
- Retorna a área de um triângulo caso receba um valor do tipo int e outro valor do tipo double;
- Retorna a área de um triângulo caso receba 3 vetores com pares ordenados (coordenadas cartesianas x e y)
- Retorna o texto “Uso incorreto” caso receba uma cadeia de caracteres (string).
*/

using UtilsTools;

namespace EXERC_03;

class Program
{
    static void Main(string[] args)
    {
        double vNumDouble1, vNumDouble2, vNumDouble3, vNumDouble4;
        int vNumInt1, vNumInt2, vNumInt3, vNumInt4;
        string vNumStr;

        int[,] pontos = new int[3, 2];
        int[] pontoXY = new int[2];
        int[] pt1 = new int[2];
        int[] pt2 = new int[2];
        int[] pt3 = new int[2];

        ResultData resultData = new ResultData();

        InitEnd();

        Console.WriteLine("Deseja entrar com os dados manualmente");
        Console.WriteLine("ou, exibir uma simulação pré-configurada?\n");
        Console.WriteLine("  •               1 : ENTRADA MANUAL");
        Console.WriteLine("  • QUALQUER NÚMERO : SIMULAÇÃO");
        Console.WriteLine("\n");

        int op = Utils.ConvertEntradaStringToInt(" - Opção : ");

        InitEnd();

        if (op == 1)
        {
            Console.WriteLine("             ----- ENTRADA MANUAL -----\n");
            Console.WriteLine("Obs.: Considere todos valores em m(metros).\n");

            // -------------------------------------------------
            Console.WriteLine(" 1 - ÁREA - CÍRCULO");
            Console.WriteLine("     Informe um diâmetro (real):");
            vNumDouble1 = Utils.ConvertEntradaStringToDouble(" - Valor : ");
            resultData.AreaCirculo = CalcAreaPerimetro.Calcular(vNumDouble1);

            // -------------------------------------------------
            Console.WriteLine("\n");
            Console.WriteLine(" 2 - ÁREA - QUADRADO / RETÂNGULO");
            Console.WriteLine("     Informe dois lados (real):");
            vNumDouble1 = Utils.ConvertEntradaStringToDouble(" - Lado 1 : ");
            vNumDouble2 = Utils.ConvertEntradaStringToDouble(" - Lado 2 : ");
            resultData.AreaQuadradoRetangulo = CalcAreaPerimetro.Calcular(vNumDouble1, vNumDouble2);

            // -------------------------------------------------
            Console.WriteLine("\n");
            Console.WriteLine(" 3 - PERÍMETRO - TRIÂNGULO");
            Console.WriteLine("     Informe três lados (valores inteiros):");
            vNumInt1 = Utils.ConvertEntradaStringToInt(" - Lado 1 : ");
            vNumInt2 = Utils.ConvertEntradaStringToInt(" - Lado 2 : ");
            vNumInt3 = Utils.ConvertEntradaStringToInt(" - Lado 3 : ");
            resultData.PerimetroTriangulo = CalcAreaPerimetro.Calcular(vNumInt1, vNumInt2, vNumInt3);

            // -------------------------------------------------
            Console.WriteLine("\n");
            Console.WriteLine(" 4 - ÁREA - TRIÂNGULO");
            Console.WriteLine("     Informe a base(inteiro) e altura(real)):");
            vNumInt1 = Utils.ConvertEntradaStringToInt(" -   Base : ");
            vNumDouble1 = Utils.ConvertEntradaStringToInt(" - Altura : ");
            resultData.AreaTriangulo = CalcAreaPerimetro.Calcular(vNumInt1, vNumDouble1);

            // -------------------------------------------------
            Console.WriteLine("\n");
            Console.WriteLine(" 5 - ÁREA - TRIÂNGULO (COORDENADAS CARTESIANAS)");
            Console.WriteLine("     Informe 3 pontos [X(inteiro), Y(inteiro)]:");

            for (int i = 0; i < 3; i++)
            {
                if (i == 0) Console.ForegroundColor = ConsoleColor.DarkRed;
                if (i == 1) Console.ForegroundColor = ConsoleColor.DarkGreen;
                if (i == 2) Console.ForegroundColor = ConsoleColor.DarkCyan;

                pontoXY[0] = Utils.ConvertEntradaStringToInt($" -   X.{i + 1} : ");
                pontoXY[1] = Utils.ConvertEntradaStringToInt($" -   Y.{i + 1} : ");
                pontos[i, 0] = pontoXY[0];
                pontos[i, 1] = pontoXY[1];

                Console.ResetColor();
            }

            pt1[0] = pontos[0, 0]; pt1[1] = pontos[0, 1];
            pt2[0] = pontos[1, 0]; pt2[1] = pontos[1, 1];
            pt3[0] = pontos[2, 0]; pt3[1] = pontos[2, 1];
            resultData.AreaTrianguloCoord = CalcAreaPerimetro.Calcular(pt1, pt2, pt3);

            // -------------------------------------------------
            Console.WriteLine("\n");
            Console.WriteLine(" 6 - USO INCORRETO");
            Console.WriteLine("     Informe qualquer valor não numérico:");
            Console.Write(" -   String : ");
            vNumStr = Console.ReadLine() ?? "";
            resultData.UsoIncorreto = CalcAreaPerimetro.Calcular(vNumStr);


            InitEnd();

            Console.WriteLine("             ----- RESULTADO -----\n");

            Console.WriteLine($" • .............. ÁREA - CÍRCULO  =  {resultData.AreaCirculo:F2} m2");
            Console.WriteLine($" • . ÁREA - QUADRADO / RETÂNGULO  =  {resultData.AreaQuadradoRetangulo:F2} m2");
            Console.WriteLine($" • ....... PERÍMETRO - TRIÂNGULO  =  {resultData.PerimetroTriangulo:F2} m2");
            Console.WriteLine($" • ............ ÁREA - TRIÂNGULO  =  {resultData.AreaTriangulo:F2} m2");
            Console.WriteLine($" • ... ÁREA - TRIÂNGULO (COORD.)  =  {resultData.AreaTrianguloCoord:F2} m2");
            Console.WriteLine($" • ............... USO INCORRETO  =  {resultData.UsoIncorreto}");
        }
        else
        {
            vNumDouble1 = 2.5; // 1 - Área - Círculo
            vNumDouble2 = 2.0; // 2 - Área - Quadrado / Retangulo
            vNumDouble3 = 4.0; // 2 - Área - Quadrado / Retangulo
            vNumInt1 = 3; // 3 - Perímetro - Triângulo
            vNumInt2 = 4; // 3 - Perímetro - Triângulo
            vNumInt3 = 5; // 3 - Perímetro - Triângulo
            vNumInt4 = 2; // 4 - Área - Triângulo
            vNumDouble4 = 4.2; // 4 - Área - Triângulo
            pt1 = new int[] { 0, 0 }; // 5 - Área - Triângulo (Coord)
            pt2 = new int[] { 0, 2 }; // 5 - Área - Triângulo (Coord)
            pt3 = new int[] { 5, 0 }; // 5 - Área - Triângulo (Coord)
            vNumStr = "Texto Qualquer..."; // 6 - Uso Incorreto


            Console.WriteLine("             ----- SIMULAÇÃO -----\n");

            Console.WriteLine(" Dados para teste (metro):");

            Console.WriteLine($" • .............. ÁREA - CÍRCULO  = {vNumDouble1}");
            resultData.AreaCirculo = CalcAreaPerimetro.Calcular(vNumDouble1);

            Console.WriteLine($" • . ÁREA - QUADRADO / RETÂNGULO  = {vNumDouble2}   {vNumDouble3}");
            resultData.AreaQuadradoRetangulo = CalcAreaPerimetro.Calcular(vNumDouble2, vNumDouble3);

            Console.WriteLine($" • ....... PERÍMETRO - TRIÂNGULO  = {vNumInt1}   {vNumInt2}   {vNumInt3}");
            resultData.PerimetroTriangulo = CalcAreaPerimetro.Calcular(vNumInt1, vNumInt2, vNumInt3);

            Console.WriteLine($" • ............ ÁREA - TRIÂNGULO  = {vNumInt4}   {vNumDouble4}");
            resultData.AreaTriangulo = CalcAreaPerimetro.Calcular(vNumInt4, vNumDouble4);

            Console.WriteLine($" • ... ÁREA - TRIÂNGULO (COORD.)  = ({pt1[0]},{pt1[1]})  ({pt2[0]},{pt2[1]})  ({pt3[0]},{pt3[1]})");
            resultData.AreaTrianguloCoord = CalcAreaPerimetro.Calcular(pt1, pt2, pt3);

            Console.WriteLine($" • ............... USO INCORRETO  = {vNumStr}");
            resultData.UsoIncorreto = CalcAreaPerimetro.Calcular(vNumStr);


            Console.WriteLine("\n\n             ----- RESULTADO -----\n");

            Console.WriteLine($" • .............. ÁREA - CÍRCULO  =  {resultData.AreaCirculo:F2} m2");
            Console.WriteLine($" • . ÁREA - QUADRADO / RETÂNGULO  =  {resultData.AreaQuadradoRetangulo:F2} m2");
            Console.WriteLine($" • ....... PERÍMETRO - TRIÂNGULO  =  {resultData.PerimetroTriangulo:F2} m2");
            Console.WriteLine($" • ............ ÁREA - TRIÂNGULO  =  {resultData.AreaTriangulo:F2} m2");
            Console.WriteLine($" • ... ÁREA - TRIÂNGULO (COORD.)  =  {resultData.AreaTrianguloCoord:F2} m2");
            Console.WriteLine($" • ............... USO INCORRETO  =  {resultData.UsoIncorreto}");
        }

        InitEnd(0);
    }


    static void InitEnd(int? opcao = 1)
    {
        if (opcao == 1)
        {
            Console.Clear();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("             CALCULADORA: ÁREA | PERÍMETRO           ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("\n");
            return;
        }

        Console.WriteLine("\n\n ----- Pressione uma tecla para sair -----");
        Console.ReadKey();
    }


}