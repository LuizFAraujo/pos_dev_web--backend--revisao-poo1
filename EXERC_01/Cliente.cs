using System.Text.RegularExpressions;

namespace EXERC_01
{
    public class Cliente
    {
        private string nome = "";
        private string endereco = "";
        private string cep = "";
        private string cpf = "";

        public string Nome { get { return nome; } set { nome = value; } }
        public string Endereco { get { return endereco; } set { endereco = value; } }
        public string CEP { get { return cep; } set { cep = value; } }

        public string CPF
        {
            get { return cpf; }
            set
            {
                // Validar CPF usando RegEx
                if (Regex.IsMatch(value, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$"))
                    cpf = value;
                else
                    throw new ArgumentException("*** CPF INVÁLIDO ***");
            }
        }
        public void ExibirDados()
        {
            Console.WriteLine($"•     Nome: {Nome}");
            Console.WriteLine($"• Endereço: {Endereco}");
            Console.WriteLine($"•      CEP: {CEP}");
            Console.WriteLine($"•      CPF: {CPF}");
        }
    }
}