using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================");
            Console.WriteLine(" Cadastro de Funcionários ");
            Console.WriteLine("=========================");

            Console.WriteLine("Digite o Nome do Funcionário: ");
            string dsNome = Console.ReadLine();

            Console.WriteLine("Indique o Sexo: ");
            char dsSexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Informe a Data de Nascimento: ");
            DateTime dtNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Insira o Valor de Salário: ");
            Decimal nrSalario = Convert.ToDecimal(Console.ReadLine());

            string mensagem = "RESUMO";
            mensagem += "\nNome: " + dsNome;
            mensagem += "\nSexo: " + dsSexo;
            mensagem += "\nNascimento: " + dtNascimento;
            mensagem += "\nSalário: " + nrSalario;

            Console.WriteLine(mensagem);
            Console.ReadLine();
        }
    }
}
