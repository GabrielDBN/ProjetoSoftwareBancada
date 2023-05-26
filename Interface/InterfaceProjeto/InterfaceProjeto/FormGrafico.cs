using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InterfaceProjeto
{
    public partial class FormGrafico : Form
    {
        public FormGrafico()
        {
            InitializeComponent();
        }

        private void FormGrafico_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
