namespace InterfaceProjeto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            carregarToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            operadorToolStripMenuItem = new ToolStripMenuItem();
            motorToolStripMenuItem = new ToolStripMenuItem();
            testeToolStripMenuItem = new ToolStripMenuItem();
            visualizarToolStripMenuItem = new ToolStripMenuItem();
            gráficoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, adicionarToolStripMenuItem, visualizarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { carregarToolStripMenuItem, salvarToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(75, 24);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // carregarToolStripMenuItem
            // 
            carregarToolStripMenuItem.Name = "carregarToolStripMenuItem";
            carregarToolStripMenuItem.Size = new Size(224, 26);
            carregarToolStripMenuItem.Text = "Carregar";
            carregarToolStripMenuItem.Click += carregarToolStripMenuItem_Click_1;
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(224, 26);
            salvarToolStripMenuItem.Text = "Salvar";
            salvarToolStripMenuItem.Click += salvarToolStripMenuItem_Click;
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { operadorToolStripMenuItem, motorToolStripMenuItem, testeToolStripMenuItem });
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(87, 24);
            adicionarToolStripMenuItem.Tag = "";
            adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // operadorToolStripMenuItem
            // 
            operadorToolStripMenuItem.Name = "operadorToolStripMenuItem";
            operadorToolStripMenuItem.Size = new Size(224, 26);
            operadorToolStripMenuItem.Text = "Operador";
            operadorToolStripMenuItem.Click += operadorToolStripMenuItem_Click;
            // 
            // motorToolStripMenuItem
            // 
            motorToolStripMenuItem.Name = "motorToolStripMenuItem";
            motorToolStripMenuItem.Size = new Size(224, 26);
            motorToolStripMenuItem.Text = "Motor";
            motorToolStripMenuItem.Click += motorToolStripMenuItem_Click;
            // 
            // testeToolStripMenuItem
            // 
            testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            testeToolStripMenuItem.Size = new Size(224, 26);
            testeToolStripMenuItem.Text = "Teste";
            testeToolStripMenuItem.Click += testeToolStripMenuItem_Click;
            // 
            // visualizarToolStripMenuItem
            // 
            visualizarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gráficoToolStripMenuItem });
            visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            visualizarToolStripMenuItem.Size = new Size(86, 24);
            visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // gráficoToolStripMenuItem
            // 
            gráficoToolStripMenuItem.Name = "gráficoToolStripMenuItem";
            gráficoToolStripMenuItem.Size = new Size(224, 26);
            gráficoToolStripMenuItem.Text = "Gráfico";
            gráficoToolStripMenuItem.Click += gráficoToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Logo_BRAVO___Resized;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(782, 453);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Software Bancada de Empuxo";
            Resize += Form1_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem operadorToolStripMenuItem;
        private ToolStripMenuItem motorToolStripMenuItem;
        private ToolStripMenuItem testeToolStripMenuItem;
        private ToolStripMenuItem visualizarToolStripMenuItem;
        private ToolStripMenuItem gráficoToolStripMenuItem;
        private ToolStripMenuItem carregarToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
    }
}