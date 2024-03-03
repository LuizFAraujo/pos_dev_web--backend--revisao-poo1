using System.Text.RegularExpressions;

namespace CPF_Utils;

public class CPF
{
    private string cpf = "";
    private bool isCpfOk;

    public string NumCPF { get { return cpf; } set { cpf = value; } }
    public bool IsCpfOk { get { return isCpfOk; } set { isCpfOk = value; } }


    public bool ValidarCPF(string cpf, bool byRegex = true)
    {
        // Remove caracteres não numéricos
        cpf = new string(cpf.Where(char.IsDigit).ToArray());

        // Verificar se o CPF possui 11 dígitos
        if (cpf.Length != 11) return false;

        if (byRegex)
        {
            // Cria o padrão regex para o CPF
            string pattern = @"^(\d{3})(\d{3})(\d{3})(\d{2})$";

            // Verifica se o CPF não corresponde ao padrão
            if (!Regex.IsMatch(cpf, pattern)) return false;
        }

        // Calcular os dígitos verificadores
        int soma = 0;
        int peso = 10;

        for (int i = 0; i < 9; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * peso;
            peso--;
        }

        int digito1 = 11 - (soma % 11);
        if (digito1 > 9) digito1 = 0;

        soma = 0;
        peso = 11;

        for (int i = 0; i < 10; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * peso;
            peso--;
        }

        int digito2 = 11 - (soma % 11);
        if (digito2 > 9) digito2 = 0;

        // Verificar se os dígitos calculados são iguais aos dígitos informados
        return cpf.EndsWith(digito1.ToString() + digito2.ToString());
    }

}
