namespace EXERC_02
{
    public static class Utils_Primos
    {
        public static bool CheckNumeroPrimo(int num)
        {
            if (num < 2) return false;

            for (int divisor = 2; divisor <= Math.Sqrt(num); divisor++)
                if (num % divisor == 0) return false;

            return true;
        }

        public static int ContaPrimos(int num1, int num2)
        {
            int contador = 0;
            for (int i = num1; i <= num2; i++)
                if (CheckNumeroPrimo(i)) contador++;

            return contador;
        }
    }
}