using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceProjeto.Objects;
using MySql.Data.MySqlClient;

namespace InterfaceProjeto
{
    public partial class FormMotor : Form
    {
        private Motor motor;

        public FormMotor()
        {
            InitializeComponent();
        }

        internal Motor Motor { get => motor; set => motor = value; }

        private void btnAddM_Click(object sender, EventArgs e)
        {
            this.motor = new Motor();
            motor.codMotor = txtCodMotor.Text;
            motor.classe = txtClasseMotor.Text;
            motor.propelente = txtPropMotor.Text;
            motor.material = txtMatMotor.Text;
            motor.massa = txtMassaMotor.Text;
            motor.massaPos = txtMVMotor.Text;
            motor.dataFabri = dateTimeMotor.Value;
            motor.CadastrarMotor();

            MessageBox.Show("Motor adicionado");
        }

        private void btnSairM_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
