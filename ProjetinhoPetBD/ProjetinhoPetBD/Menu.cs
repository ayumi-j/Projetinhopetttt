using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinhoPetBD
{
    class Menu
    {
        public string menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar pet");
            Console.WriteLine("2 - Cadastrar pessoa ");
            Console.WriteLine("3 - Marcar consulta");
            Console.WriteLine("4 - visualizar pessoa");
            Console.WriteLine("5 - visualizar pet");
            Console.WriteLine("6 - visualizar consulta");
            Console.WriteLine("S - Sair");
            Console.WriteLine("Escolha uma opcao:");
            string opcao;
            opcao = Console.ReadLine();
            return opcao.ToUpper();
        }
    }
}
