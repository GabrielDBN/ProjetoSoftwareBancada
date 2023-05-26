using InterfaceProjeto.Objects;
using Spire.Doc;
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

namespace InterfaceProjeto
{
    public partial class FrmSalvar : Form
    {
        private Form1 form1;

        public FrmSalvar(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void FrmSalvar_Load(object sender, EventArgs e)
        {
            Operador operador = new Operador();
            ArrayList listaOp = operador.ListarOperadores();

            foreach (Operador op in listaOp)
            {
                CmbBoxOperador.Items.Add(op);
            }

            Motor motor = new Motor();
            ArrayList listaM = motor.ListarMotores();

            foreach (Motor m in listaM)
            {
                CmbBoxMotor.Items.Add(m);
            }

            Teste teste = new Teste();
            ArrayList listaT = teste.ListarTestes();

            foreach (Teste t in listaT)
            {
                CmbBoxTeste.Items.Add(t);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog2 = new OpenFileDialog();

            if (openfiledialog2.ShowDialog() == DialogResult.OK)
            {
                string relatorioBase = openfiledialog2.FileName;
                Document document = new Document();
                document.LoadFromFile(relatorioBase);

                Operador operador = (Operador)CmbBoxOperador.SelectedItem;
                document.Replace("(Nome do Operador)", operador.nome, false, true);
                document.Replace("(Cargo)", operador.cargo, false, true);

                Motor motor = (Motor)CmbBoxMotor.SelectedItem;
                document.Replace("(CódigoM)", motor.codMotor, false, true);
                document.Replace("(Classe)", motor.classe, false, true);
                document.Replace("(Propelente)", motor.propelente, false, true);
                document.Replace("(Material)", motor.material, false, true);
                document.Replace("(Massa)", motor.massa, false, true);
                document.Replace("(MassaPos)", motor.massaPos, false, true);
                document.Replace("(DataFabri)", motor.dataFabri.ToString(), false, true);

                Teste teste = (Teste)CmbBoxTeste.SelectedItem;
                document.Replace("(CodTeste)", teste.codTeste, false, true);
                document.Replace("(Local)", teste.localEnsaio, false, true);
                document.Replace("(Data)", teste.dia.ToString(), false, true);
                document.Replace("(Hora)", teste.hora.ToString(), false, true);
                document.Replace("(Célula)", teste.celula, false, true);
                document.Replace("(Observações)", teste.observacoes, false, true);

                string diretorioBase = Path.GetDirectoryName(relatorioBase);
                string NomeDocumento = "Documento Motor.docx";
                string relatorioFinal = Path.Combine(diretorioBase, NomeDocumento);

                document.SaveToFile(relatorioFinal, FileFormat.Docx);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
