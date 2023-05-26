namespace InterfaceProjeto
{
    using System.IO;
    using MySql.Data.MySqlClient;
    using Spire.Doc;
    using Spire.Doc.Documents;
    using System.Windows.Forms;
    using InterfaceProjeto.DB;

    public partial class Form1 : Form
    {
        public FormOperador formOperador;
        public FormMotor formMotor;
        public FormTeste formTeste;
        public FormGrafico formGrafico;
        public FrmSalvar formFrmSalvar;

        public Form1()
        {
            InitializeComponent();

            foreach (Control cor in this.Controls)
            {
                if (cor is MdiClient)
                {
                    cor.BackColor = Color.White;
                }
            }
        }

        private void carregarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();

            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                string caminho = openfiledialog1.FileName;
                string readtext = System.IO.File.ReadAllText(caminho);

                string[] linhas = readtext.Split('\n');
                int quantL = linhas.Length;
                double[,] array = new double[quantL, 2];

                for (int i = 0; i < quantL - 1; i++)
                {
                    string[] colunas = linhas[i].Split(' ');
                    array[i, 0] = Convert.ToDouble(colunas[1]);
                    array[i, 1] = Convert.ToDouble(colunas[7].Replace(':', '.'));
                }
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banco.getConexao();

            if (formFrmSalvar == null || formFrmSalvar.ActiveControl == null)
            {
                formFrmSalvar = new FrmSalvar(this);
                formFrmSalvar.MdiParent = this;
                formFrmSalvar.Show();
            }
            else
            {
                formFrmSalvar.Show();
            }
        }

        private void operadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formOperador == null || formOperador.ActiveControl == null)
            {
                formOperador = new FormOperador();
                formOperador.MdiParent = this;
                formOperador.Show();
            }
            else
            {
                formOperador.Show();
            }
        }

        private void motorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formMotor == null || formMotor.ActiveControl == null)
            {
                formMotor = new FormMotor();
                formMotor.MdiParent = this;
                formMotor.Show();
            }
            else
            {
                formMotor.Show();
            }
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formTeste == null || formTeste.ActiveControl == null)
            {
                formTeste = new FormTeste();
                formTeste.MdiParent = this;
                formTeste.Show();
            }
            else
            {
                formTeste.Show();
            }
        }

        private void gráficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formGrafico == null || formGrafico.ActiveControl == null)
            {
                formGrafico = new FormGrafico();
                formGrafico.MdiParent = this;
                formGrafico.Show();
            }
            else
            {
                formGrafico.Show();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}