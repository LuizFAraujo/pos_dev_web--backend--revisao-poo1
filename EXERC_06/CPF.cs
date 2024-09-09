using System.Text.RegularExpressions;

namespace CPF_Utils
{
    public class CPF
    {
        private string cpf = string.Empty;
        private bool isCpfOk;

        public string NumCPF
        {
            get => cpf;
            set => cpf = value;
        }

        public bool IsCpfOk
        {
            get => isCpfOk;
            set => isCpfOk = value;
        }

        public bool ValidarCPF(string cpf, bool useRegex = true)
        {
            string cleanedCpf = CleanCpf(cpf);

            if (!IsLengthValid(cleanedCpf))
                return false;

            if (useRegex && !IsFormatValid(cleanedCpf))
                return false;

            return AreDigitsValid(cleanedCpf);
        }

        private string CleanCpf(string cpf)
        {
            return new string(cpf.Where(char.IsDigit).ToArray());
        }

        private bool IsLengthValid(string cpf)
        {
            return cpf.Length == 11;
        }

        private bool IsFormatValid(string cpf)
        {
            string pattern = @"^\d{11}$";
            return Regex.IsMatch(cpf, pattern);
        }

        private bool AreDigitsValid(string cpf)
        {
            int firstDigit = CalculateDigit(cpf, 10);
            int secondDigit = CalculateDigit(cpf, 11);

            string calculatedDigits = $"{firstDigit}{secondDigit}";

            return cpf.EndsWith(calculatedDigits);
        }

        private int CalculateDigit(string cpf, int weight)
        {
            int sum = 0;

            for (int i = 0; i < cpf.Length - 1; i++)
            {
                sum += int.Parse(cpf[i].ToString()) * weight;
                weight--;
            }

            int digit = 11 - (sum % 11);
            return digit > 9 ? 0 : digit;
        }
    }
}
