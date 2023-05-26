using Google.Protobuf.WellKnownTypes;
using InterfaceProjeto.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace InterfaceProjeto.Objects
{
    class Teste
    {
        public string CodTeste;
        public string LocalEnsaio;
        public DateTime Dia;
        public string Hora;
        public string Celula;
        public string Observacoes;

        public bool CadastrarTeste()
        {
            using (MySqlConnection conexaoIT = Banco.getConexao())
            {
                string queryIT = $"INSERT INTO Teste (CodTeste, LocalEnsaio, Dia, Hora, Celula, Observacoes) VALUES ('{CodTeste}', '{LocalEnsaio}', '{Dia.ToString("yyyy-MM-dd")}', '{Hora}', '{Celula}', '{Observacoes}')";
                using (MySqlCommand comandoIT = new MySqlCommand(queryIT, conexaoIT))
                {
                    conexaoIT.Open();
                    comandoIT.ExecuteNonQuery();
                }
            }

            return true;
        }

        public ArrayList ListarTestes()
        {
            ArrayList testes = new ArrayList();

            using (MySqlConnection conexaoLT = Banco.getConexao())
            {
                conexaoLT.Open();

                string queryST = "SELECT * from Teste";
                using (MySqlCommand comandoST = new MySqlCommand(queryST, conexaoLT))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comandoST))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Teste teste = new Teste();
                            teste.codTeste = row["CodTeste"].ToString();
                            teste.localEnsaio = row["LocalEnsaio"].ToString();
                            teste.dia = Convert.ToDateTime(row["Dia"]);
                            teste.hora = row["Hora"].ToString();
                            teste.celula = row["Celula"].ToString();
                            teste.observacoes = row["Observacoes"].ToString();
                            testes.Add(teste);
                        }
                    }
                }
            }

            return testes;
        }


        public override string ToString()
        {
            return codTeste + " - " + localEnsaio + " - " + dia + " - " + hora + " - " + celula + " - " + observacoes;
        }

        public string codTeste
        {
            get { return CodTeste; }
            set { CodTeste = value; }
        }
        public string localEnsaio
        {
            get { return LocalEnsaio; }
            set { LocalEnsaio = value; }
        }
        public DateTime dia
        {
            get { return Dia; }
            set { Dia = value; }
        }
        public string hora
        {
            get { return Hora; }
            set { Hora = value; }
        }
        public string celula
        {
            get { return Celula; }
            set { Celula = value; }
        }

        public string observacoes
        {
            get { return Observacoes; }
            set { Observacoes = value; }
        }
    }
}
