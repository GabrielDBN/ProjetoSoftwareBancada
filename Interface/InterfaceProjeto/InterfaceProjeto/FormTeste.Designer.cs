namespace InterfaceProjeto
{
    partial class FormTeste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeste));
            txtCodTeste = new TextBox();
            txtHoraTeste = new TextBox();
            txtCelTeste = new TextBox();
            btnAddTeste = new Button();
            btnSairTeste = new Button();
            lblTeste = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimeTeste = new DateTimePicker();
            label1 = new Label();
            txtLocalT = new TextBox();
            label6 = new Label();
            txtObsTeste = new TextBox();
            SuspendLayout();
            // 
            // txtCodTeste
            // 
            txtCodTeste.Location = new Point(133, 75);
            txtCodTeste.Name = "txtCodTeste";
            txtCodTeste.Size = new Size(125, 27);
            txtCodTeste.TabIndex = 0;
            // 
            // txtHoraTeste
            // 
            txtHoraTeste.Location = new Point(363, 71);
            txtHoraTeste.Name = "txtHoraTeste";
            txtHoraTeste.Size = new Size(125, 27);
            txtHoraTeste.TabIndex = 2;
            // 
            // txtCelTeste
            // 
            txtCelTeste.Location = new Point(363, 129);
            txtCelTeste.Name = "txtCelTeste";
            txtCelTeste.Size = new Size(125, 27);
            txtCelTeste.TabIndex = 3;
            // 
            // btnAddTeste
            // 
            btnAddTeste.Location = new Point(125, 378);
            btnAddTeste.Name = "btnAddTeste";
            btnAddTeste.Size = new Size(96, 43);
            btnAddTeste.TabIndex = 4;
            btnAddTeste.Text = "Adicionar";
            btnAddTeste.UseVisualStyleBackColor = true;
            btnAddTeste.Click += btnAddTeste_Click;
            // 
            // btnSairTeste
            // 
            btnSairTeste.Location = new Point(312, 378);
            btnSairTeste.Name = "btnSairTeste";
            btnSairTeste.Size = new Size(96, 43);
            btnSairTeste.TabIndex = 5;
            btnSairTeste.Text = "Sair";
            btnSairTeste.UseVisualStyleBackColor = true;
            btnSairTeste.Click += btnSairTeste_Click;
            // 
            // lblTeste
            // 
            lblTeste.AutoSize = true;
            lblTeste.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTeste.Location = new Point(125, 21);
            lblTeste.Name = "lblTeste";
            lblTeste.Size = new Size(263, 23);
            lblTeste.TabIndex = 6;
            lblTeste.Text = "Coloque as informações abaixo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 78);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 7;
            label2.Text = "Codinome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 180);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 8;
            label3.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(312, 74);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 9;
            label4.Text = "Hora:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(304, 132);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 10;
            label5.Text = "Célula:";
            // 
            // dateTimeTeste
            // 
            dateTimeTeste.Location = new Point(133, 180);
            dateTimeTeste.Name = "dateTimeTeste";
            dateTimeTeste.Size = new Size(250, 27);
            dateTimeTeste.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 132);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 12;
            label1.Text = "Local de ensaio:";
            // 
            // txtLocalT
            // 
            txtLocalT.Location = new Point(133, 129);
            txtLocalT.Name = "txtLocalT";
            txtLocalT.Size = new Size(125, 27);
            txtLocalT.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 235);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 14;
            label6.Text = "Observações:";
            // 
            // txtObsTeste
            // 
            txtObsTeste.Location = new Point(133, 232);
            txtObsTeste.Multiline = true;
            txtObsTeste.Name = "txtObsTeste";
            txtObsTeste.Size = new Size(330, 124);
            txtObsTeste.TabIndex = 15;
            // 
            // FormTeste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 437);
            Controls.Add(txtObsTeste);
            Controls.Add(label6);
            Controls.Add(txtLocalT);
            Controls.Add(label1);
            Controls.Add(dateTimeTeste);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTeste);
            Controls.Add(btnSairTeste);
            Controls.Add(btnAddTeste);
            Controls.Add(txtCelTeste);
            Controls.Add(txtHoraTeste);
            Controls.Add(txtCodTeste);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormTeste";
            Text = "Teste";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodTeste;
        private TextBox txtHoraTeste;
        private TextBox txtCelTeste;
        private Button btnAddTeste;
        private Button btnSairTeste;
        private Label lblTeste;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimeTeste;
        private Label label1;
        private TextBox txtLocalT;
        private Label label6;
        private TextBox txtObsTeste;
    }
}