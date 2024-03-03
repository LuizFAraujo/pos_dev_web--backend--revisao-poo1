namespace EXERC_02
{
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
    }
}