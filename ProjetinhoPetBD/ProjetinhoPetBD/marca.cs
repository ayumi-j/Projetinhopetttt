using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetinhoPetBD
{
    class marca
    {
        int cpf;
        DateTime data;


        public void marcahora()
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
            MySqlCommand cmd;//cmd pode ser qualquer 

            Console.WriteLine("Digite o seu CPF");
            int cpf;
            cpf = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Data da consulta: {0}", cpf);
            DateTime data;
            data = DateTime.Parse(Console.ReadLine());




            string sql;
            sql = "insert into consulta values(@cpf, @data)";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@data", data);

            cmd.ExecuteNonQuery();
            conexao.Close();


            Console.ReadKey();

        }
        public void visuhora()
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

            string sql;
            sql = "select * from consulta ";
            cmd = new MySqlCommand(sql, conexao);

            cmd.ExecuteNonQuery();
            conexao.Close();


            Console.ReadKey();
        }
    }
}
