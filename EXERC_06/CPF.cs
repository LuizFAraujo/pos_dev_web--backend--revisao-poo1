using System.Text.RegularExpressions;

namespace CPF_Utils;

public class CPF
{
    private string _cpf = string.Empty;
    private bool _isCpfValid;

    public string NumCPF
    {
        get => _cpf;
        set => _cpf = value;
    }

    public bool IsCpfValid
    {
        get => _isCpfValid;
        private set => _isCpfValid = value;
    }

    public bool Validate(string cpf, bool useRegex = true)
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
        const string pattern = @"^\d{11}$";
        return Regex.IsMatch(cpf, pattern);
    }

    private bool AreDigitsValid(string cpf)
    {
        if (HasAllDigitsSame(cpf))
            return false;

        int firstDigit = CalculateDigit(cpf, 10);
        int secondDigit = CalculateDigit(cpf, 11);

        string calculatedDigits = $"{firstDigit}{secondDigit}";

        return cpf.EndsWith(calculatedDigits);
    }

    private bool HasAllDigitsSame(string cpf)
    {
        return cpf.Distinct().Count() == 1;
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
