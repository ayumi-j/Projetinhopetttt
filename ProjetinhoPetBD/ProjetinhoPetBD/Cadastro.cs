using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetinhoPetBD
{
    class Cadastro
    {
        string NomePet;
        string Especie;
        string Raca;
        int IdadePet;
        int IdPet;
        string NomePes;
        int cpf;
        int telefone;
        string endereco;


        public void cadpet()
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

            Console.WriteLine("Digite o nome do Pet");
            string nomepet;
            nomepet = Console.ReadLine();
            Console.WriteLine("Digite a especie do Pet: {0}", nomepet);
            string especie;
            especie = Console.ReadLine();
            Console.WriteLine("Digite a raça do Pet: {0}", nomepet);
            string raca;
            raca = Console.ReadLine();
            Console.WriteLine("Digite a idade do pet: {0}", nomepet);
            string idadepet;
            idadepet = Console.ReadLine();
            Console.WriteLine("Digite a ID do Pet; {0}", nomepet);
            string idpet;
            idpet = Console.ReadLine();

            string sql;
            sql = "insert into cadastropet values(@nomepet, @especie, @raca, @idadepet, @idpet)";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nomepet", nomepet);
            cmd.Parameters.AddWithValue("@especie", especie);
            cmd.Parameters.AddWithValue("@raca", raca);
            cmd.Parameters.AddWithValue("@idadepet", idadepet);
            cmd.Parameters.AddWithValue("@idpet", idpet);
            cmd.ExecuteNonQuery();
            conexao.Close();


            Console.ReadKey();


        }

        public void visucadpet()
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


            string sql;
            sql = "select * from cadastropet";
            cmd = new MySqlCommand(sql, conexao);

            cmd.ExecuteNonQuery();
            conexao.Close();


            Console.ReadKey();


        }

        /// <summary>
        /// 
        /// </summary>
        public void cadpessoa()
        {
            MySqlConnection conexaopes;
            conexaopes = new MySqlConnection("server=localhost;database=projetinho;uid=root;password=vertrigo");
            try
            {
                conexaopes.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Não foi possivel conectar-se ao banco");
                Console.ReadKey();
                Environment.Exit(0);
            }
            MySqlCommand cmdpes;//cmd pode ser qualquer 

            Console.WriteLine("Digite seu nome");
            string nomepes;
            nomepes = Console.ReadLine();
            Console.WriteLine("Digite seu telefone: {0}", nomepes);
            string telefone;
            telefone = Console.ReadLine();
            Console.WriteLine("Digite seu cep: {0}", nomepes);
            string cep;
            cep = Console.ReadLine();
            Console.WriteLine("Digite seu cpf: {0}", nomepes);
            string cpf;
            cpf = Console.ReadLine();


            string sqlpes;
            sqlpes = "insert into cadastropes values(@nomepes, @telefone, @cep, @cpf)";
            cmdpes = new MySqlCommand(sqlpes, conexaopes);
            cmdpes.Parameters.AddWithValue("@nomepes", nomepes);
            cmdpes.Parameters.AddWithValue("@telefone", telefone);
            cmdpes.Parameters.AddWithValue("@cep", cep);
            cmdpes.Parameters.AddWithValue("@cpf", cpf);
            cmdpes.ExecuteNonQuery();
            conexaopes.Close();


            Console.ReadKey();
        }

        public void visucadpessoa()
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


            string sql;
            sql = "select * from cadastropes ";
            cmd = new MySqlCommand(sql, conexao);
            cmd.CommandText = sql;
            MySqlDataReader resultado = cmd.ExecuteReader();



            while (resultado.Read())
            {
                Console.WriteLine("cpf:" + resultado["cpf"]);
                Console.WriteLine("nome:" + resultado["nomepes"]);
                Console.WriteLine("telefone:" + resultado["telefone"]);
                Console.WriteLine("cep:" + resultado["cep"]);
            }

            cmd.ExecuteNonQuery();
            conexao.Close();


            Console.ReadKey();
        }
    }
}
