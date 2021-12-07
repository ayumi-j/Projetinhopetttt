using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetinhoPetBD
{
    class Deletar
    {

        int cpf;
        int idpet;


        public void deletpet()
        {

            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost;database=projetinho;uid=root;password=vertrigo");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Não foi possivel conectar-se ao banco");
                Console.ReadKey();
                Environment.Exit(0);
            }
            MySqlCommand cmd;


            Console.WriteLine("Digite o id do pet que deseja apagar:");
            idpet = int.Parse(Console.ReadLine());



            string sqldelete = "delete from cadastropet where idpet=@idpet";
            cmd = new MySqlCommand(sqldelete, conexao);
            cmd.Parameters.AddWithValue("@idpet", idpet);
            cmd.CommandText = sqldelete;
            cmd.ExecuteNonQuery();
        }

        public void deletpes()
        {

            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost;database=projetinho;uid=root;password=vertrigo");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Não foi possivel conectar-se ao banco");
                Console.ReadKey();
                Environment.Exit(0);
            }
            MySqlCommand cmd;


            Console.WriteLine("Digite o cpf do cliente que deseja apagar:");
            cpf = int.Parse(Console.ReadLine());



            string sqldelete = "delete from cadastropes where cpf=@cpf";
            cmd = new MySqlCommand(sqldelete, conexao);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.CommandText = sqldelete;
            cmd.ExecuteNonQuery();
        }
        public void deletcon()
        {

            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost;database=projetinho;uid=root;password=vertrigo");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Não foi possivel conectar-se ao banco");
                Console.ReadKey();
                Environment.Exit(0);
            }
            MySqlCommand cmd;


            Console.WriteLine("Digite o cpf para apagar a consulta:");
            cpf = int.Parse(Console.ReadLine());



            string sqldelete = "delete from consulta where cpf=@cpf";
            cmd = new MySqlCommand(sqldelete, conexao);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.CommandText = sqldelete;
            cmd.ExecuteNonQuery();
        }
    }
}
