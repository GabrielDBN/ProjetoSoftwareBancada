using InterfaceProjeto.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace InterfaceProjeto.Objects
{
    class Operador
    {
        public string Nome;
        public string Cargo;

        public bool CadastrarOp()
        {
            using (MySqlConnection conexaoIOP = Banco.getConexao())
            {
                string queryIOP = $"INSERT INTO Operador (NomeOp, Cargo) VALUES ('{Nome}', '{Cargo}')";
                using (MySqlCommand comandoIOP = new MySqlCommand(queryIOP, conexaoIOP))
                {
                    comandoIOP.ExecuteNonQuery();
                }
            }
            return true;
        }

        public ArrayList ListarOperadores()
        {
            ArrayList operadores = new ArrayList();
            using (MySqlConnection conexaoLOP = Banco.getConexao())
            {
                string querySOP = "SELECT * from Operador";
                using (MySqlCommand comandoSOP = new MySqlCommand(querySOP, conexaoLOP))
                {
                    using (MySqlDataReader resultadoSOP = comandoSOP.ExecuteReader())
                    {
                        while (resultadoSOP.Read())
                        {
                            Operador op = new Operador();
                            op.nome = resultadoSOP.GetString("NomeOp");
                            op.cargo = resultadoSOP.GetString("Cargo");
                            operadores.Add(op);
                        }
                    }
                }
            }

            return operadores;
        }

        public override string ToString()
        {
            return nome + " - " + cargo;
        }

        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }

        public string cargo
        {
            get { return Cargo; }
            set { Cargo = value; }
        }
    }
}
