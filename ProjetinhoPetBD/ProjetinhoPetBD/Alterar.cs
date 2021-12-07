using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetinhoPetBD
{
    class Alterar
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


        public void altpet()
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

            Console.WriteLine("--- Consulta ---");
            Console.WriteLine("Digite o id do pet:");
            IdPet = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do pet:");
            NomePet = Console.ReadLine();

            Console.WriteLine("Digite a especie do pet:");
            Especie = Console.ReadLine();

            Console.WriteLine("Digite a raça do pet:");
            Raca = Console.ReadLine();

            Console.WriteLine("Digite a idade do pet:");
            IdadePet = int.Parse(Console.ReadLine());


            string sql;
            sql = "update cadastropet set nomepet=@nomepet, especie=@especie, raca=@raca, idadepet=@idadepet where idpet=@idpet";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nomepet", NomePet);
            cmd.Parameters.AddWithValue("@especie", Especie);
            cmd.Parameters.AddWithValue("@raca", Raca);
            cmd.Parameters.AddWithValue("@idadepet", IdadePet);

            cmd.ExecuteNonQuery();

        }
        public void altpes()
        {

            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost;database=projetinho;uid=root");
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

            Console.WriteLine("--- Consulta ---");
            Console.WriteLine("Digite o id do pet:");
            IdPet = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do pet:");
            NomePet = Console.ReadLine();

            Console.WriteLine("Digite a especie do pet:");
            Especie = Console.ReadLine();

            Console.WriteLine("Digite a raça do pet:");
            Raca = Console.ReadLine();

            Console.WriteLine("Digite a idade do pet:");
            IdadePet = int.Parse(Console.ReadLine());


            string sql;
            sql = "update cadastropet set nomepet=@nomepet, especie=@especie, raca=@raca, idadepet=@idadepet where idpet=@idpet";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nomepet", NomePet);
            cmd.Parameters.AddWithValue("@especie", Especie);
            cmd.Parameters.AddWithValue("@raca", Raca);
            cmd.Parameters.AddWithValue("@idadepet", IdadePet);

            cmd.ExecuteNonQuery();

        }
    }
}
