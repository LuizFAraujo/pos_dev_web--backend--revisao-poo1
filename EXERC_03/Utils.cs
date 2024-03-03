namespace UtilsTools;

public static class Utils
{
    public static int ConvertEntradaStringToInt(string texto)
    {
        bool check;
        int vNum;

        do
        {
            Console.Write(texto);

            if (!int.TryParse(Console.ReadLine(), out vNum))
            {
                Console.WriteLine("O valor informado é inválido! Tente novamente.");
                check = false;
            }
            else { check = true; }

        } while (check == false);

        return vNum;
    }

    public static double ConvertEntradaStringToDouble(string texto)
    {
        bool check;
        double vNum;

        do
        {
            Console.Write(texto);

            if (!double.TryParse(Console.ReadLine(), out vNum))
            {
                Console.WriteLine("O valor informado é inválido! Tente novamente.");
                check = false;
            }
            else { check = true; }

        } while (check == false);

        return vNum;
    }
}
