
namespace EXERC_03
{
    public class CalcAreaPerimetro
    {
        // ==================================================
        // ------ 1 - Área - Círculo
        public static double Calcular(double diametro)
        {
            return Math.PI * Math.Pow(diametro / 2, 2);
        }

        // ==================================================
        // ------ 2 - Área - Quadrado / Retangulo
        public static double Calcular(double lado1, double lado2)
        {
            return lado1 * lado2;
        }

        // ==================================================
        // ------ 3 - Perímetro - Triângulo
        public static int Calcular(int lado1, int lado2, int lado3)
        {
            return lado1 + lado2 + lado3;
        }

        // ==================================================
        // ------ 4 - Área - Triângulo (@ evita conflito com palavra reservada)
        public static double Calcular(int @base, double altura)
        {
            return (@base * altura) / 2.0;
        }

        // ==================================================
        // ------ 5 - Área - Triângulo (Coordenadas Cartesianas)
        public static double Calcular(int[] p1, int[] p2, int[] p3)
        {
            // por determinante:
            // Área = |(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2|

            double a, b, c;
            a = p1[0] * (p2[1] - p3[1]);
            b = p2[0] * (p3[1] - p1[1]);
            c = p3[0] * (p1[1] - p2[1]);

            return Math.Abs((a + b + c) / 2.0);
        }

        // ==================================================
        // ------ 6 - Uso Incorreto (String)
        public static string Calcular(string texto)
        {
            return "Uso Incorreto!";
        }
    }
}