using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProjeto.DB
{
    public class Banco
    {
        private static string servidor = "localhost";
        private static string banco = "mydb";
        private static string usuario = "root";
        private static string senha = "";
        private static MySqlConnection conexao;

        public static MySqlConnection getConexao()
        {
            if (conexao == null)
            {
                conexao = new MySqlConnection($"Server={servidor};Database={banco};User Id={usuario};Password={senha};");
                conexao.Open();
            }
            return conexao;
        }
    }
}
