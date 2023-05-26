using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceProjeto.Objects;
using MySql.Data.MySqlClient;

namespace InterfaceProjeto
{
    public partial class FormOperador : Form
    {
        private Operador operador;

        public FormOperador()
        {
            InitializeComponent();
        }

        internal Operador Operador { get => operador; set => operador = value; }

        private void btnAddOp_Click(object sender, EventArgs e)
        {
            this.operador = new Operador();
            operador.nome = txtNomeOp.Text;
            operador.cargo = txtCargoOp.Text;
            operador.CadastrarOp();

            MessageBox.Show("Operador adicionado");
        }

        private void btnSairOp_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
