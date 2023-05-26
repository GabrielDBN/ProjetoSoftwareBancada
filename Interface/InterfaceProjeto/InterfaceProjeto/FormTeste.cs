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
    public partial class FormTeste : Form
    {
        private Teste teste;

        public FormTeste()
        {
            InitializeComponent();
        }

        internal Teste Teste { get => teste; set => teste = value; }

        private void btnAddTeste_Click(object sender, EventArgs e)
        {
            this.teste = new Teste();
            teste.codTeste = txtCodTeste.Text;
            teste.localEnsaio = txtLocalT.Text;
            teste.dia = dateTimeTeste.Value;
            teste.hora = txtHoraTeste.Text;
            teste.celula = txtCelTeste.Text;
            teste.observacoes = txtObsTeste.Text;
            teste.CadastrarTeste();

            MessageBox.Show("Teste adicionado");
        }

        private void btnSairTeste_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
