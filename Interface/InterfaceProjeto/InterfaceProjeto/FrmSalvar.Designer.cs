namespace InterfaceProjeto
{
    partial class FrmSalvar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalvar));
            CmbBoxOperador = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            CmbBoxMotor = new ComboBox();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            CmbBoxTeste = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // CmbBoxOperador
            // 
            CmbBoxOperador.FormattingEnabled = true;
            CmbBoxOperador.Location = new Point(148, 86);
            CmbBoxOperador.Name = "CmbBoxOperador";
            CmbBoxOperador.Size = new Size(151, 28);
            CmbBoxOperador.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(144, 295);
            button1.Name = "button1";
            button1.Size = new Size(96, 37);
            button1.TabIndex = 1;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(102, 30);
            label1.Name = "label1";
            label1.Size = new Size(411, 23);
            label1.TabIndex = 2;
            label1.Text = "Selecione as informações para colocar no relatório";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 89);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 3;
            label2.Text = "Nome - Cargo:";
            // 
            // CmbBoxMotor
            // 
            CmbBoxMotor.FormattingEnabled = true;
            CmbBoxMotor.Location = new Point(408, 86);
            CmbBoxMotor.Name = "CmbBoxMotor";
            CmbBoxMotor.Size = new Size(151, 28);
            CmbBoxMotor.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(349, 89);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 5;
            label3.Text = "Motor:";
            // 
            // button2
            // 
            button2.Location = new Point(370, 295);
            button2.Name = "button2";
            button2.Size = new Size(96, 37);
            button2.TabIndex = 6;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 177);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "Teste:";
            // 
            // CmbBoxTeste
            // 
            CmbBoxTeste.FormattingEnabled = true;
            CmbBoxTeste.Location = new Point(147, 174);
            CmbBoxTeste.Name = "CmbBoxTeste";
            CmbBoxTeste.Size = new Size(151, 28);
            CmbBoxTeste.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(342, 177);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 9;
            label5.Text = "Gráfico:";
            // 
            // FrmSalvar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 370);
            Controls.Add(label5);
            Controls.Add(CmbBoxTeste);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(CmbBoxMotor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(CmbBoxOperador);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmSalvar";
            Text = "Salvar";
            Load += FrmSalvar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CmbBoxOperador;
        private Button button1;
        private Label label1;
        private Label label2;
        private ComboBox CmbBoxMotor;
        private Label label3;
        private Button button2;
        private Label label4;
        private ComboBox CmbBoxTeste;
        private Label label5;
    }
}