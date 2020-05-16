using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadFundFormatado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("+++Cadastro de Funcionários+++");
            Console.WriteLine("==============================");

            Console.WriteLine("Digite o Nome do Funcionário: ");
            string dsNome = Console.ReadLine();

            //Alteração para char.Parse
            Console.WriteLine("Indique o Sexo: ");
            char dsSexo = char.Parse(Console.ReadLine());

            //Alteração para DateTime.Parse
            Console.WriteLine("Informe a Data de Nascimento: ");
            DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

            //Alteração para decimal.Parse
            Console.WriteLine("Insira o Valor de Salário: ");
            Decimal nrSalario = decimal.Parse(Console.ReadLine());

            //Alteraçãono formato dos itens
            string mensagem = "RESUMO";
            mensagem += string.Format("\nNome: {0}", dsNome);
            mensagem += string.Format("\nSexo: {0}", dsSexo); 
            mensagem += string.Format("\nNascimento: {0:dd/MM/yyyy}", dtNascimento); 
            mensagem += string.Format("\nSalário: {0:c2}", nrSalario); 

            Console.WriteLine(mensagem);
            Console.ReadLine();
        }
    }
}
