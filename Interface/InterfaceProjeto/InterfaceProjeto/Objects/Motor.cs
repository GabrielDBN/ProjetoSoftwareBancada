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
    class Motor
    {
        public string CodMotor;
        public string Classe;
        public string Propelente;
        public string Material;
        public string Massa;
        public string MassaPos;
        public DateTime DataFabri;

        public bool CadastrarMotor()
        {
            using (MySqlConnection conexaoIM = Banco.getConexao())
            {
                conexaoIM.Open(); // Abre a conexão com o banco de dados

                string queryIM = $"INSERT INTO Motor (CodMotor, Classe, Propelente, Material, Massa, MassaPos, DataFabri) VALUES ('{CodMotor}', '{Classe}', '{Propelente}', '{Material}', '{Massa}', '{MassaPos}', '{DataFabri.ToString("yyyy-MM-dd")}')";
                using (MySqlCommand comandoIM = new MySqlCommand(queryIM, conexaoIM))
                {
                    comandoIM.ExecuteNonQuery();
                }
            }
            return true;
        }

        public ArrayList ListarMotores()
        {
            ArrayList motores = new ArrayList();
            using (MySqlConnection conexaoLM = Banco.getConexao())
            {
                conexaoLM.Open(); // Abre a conexão com o banco de dados

                string querySM = "SELECT * from Motor";
                using (MySqlCommand comandoSM = new MySqlCommand(querySM, conexaoLM))
                {
                    using (MySqlDataReader resultadoSM = comandoSM.ExecuteReader())
                    {
                        while (resultadoSM.Read())
                        {
                            Motor motor = new Motor();
                            motor.codMotor = resultadoSM.GetString("CodMotor");
                            motor.classe = resultadoSM.GetString("Classe");
                            motor.propelente = resultadoSM.GetString("Propelente");
                            motor.material = resultadoSM.GetString("Material");
                            motor.massa = resultadoSM.GetString("Massa");
                            motor.massaPos = resultadoSM.GetString("MassaPos");
                            motor.dataFabri = resultadoSM.GetDateTime("DataFabri");
                            motores.Add(motor);
                        }
                    }
                }
            }

            return motores;
        }

        public override string ToString()
        {
            return codMotor + " - " + classe + " - " + propelente + " - " + material + " - " + massa + " - " + massaPos + " - " + dataFabri;
        }

        public string codMotor
        {
            get { return CodMotor; }
            set { CodMotor = value; }
        }

        public string classe
        {
            get { return Classe; }
            set { Classe = value; }
        }

        public string propelente
        {
            get { return Propelente; }
            set { Propelente = value; }
        }

        public string material
        {
            get { return Material; }
            set { Material = value; }
        }

        public string massa
        {
            get { return Massa; }
            set { Massa = value; }
        }

        public string massaPos
        {
            get { return MassaPos; }
            set { MassaPos = value; }
        }

        public DateTime dataFabri
        {
            get { return DataFabri; }
            set { DataFabri = value; }
        }
    }
}
