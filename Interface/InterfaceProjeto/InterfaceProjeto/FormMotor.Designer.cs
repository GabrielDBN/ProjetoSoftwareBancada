namespace InterfaceProjeto
{
    partial class FormMotor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMotor));
            btnAddM = new Button();
            btnSairM = new Button();
            txtCodMotor = new TextBox();
            txtMatMotor = new TextBox();
            txtPropMotor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblMotor = new Label();
            dateTimeMotor = new DateTimePicker();
            txtClasseMotor = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtMVMotor = new TextBox();
            txtMassaMotor = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnAddM
            // 
            btnAddM.Location = new Point(138, 277);
            btnAddM.Name = "btnAddM";
            btnAddM.Size = new Size(94, 39);
            btnAddM.TabIndex = 0;
            btnAddM.Text = "Adicionar";
            btnAddM.UseVisualStyleBackColor = true;
            btnAddM.Click += btnAddM_Click;
            // 
            // btnSairM
            // 
            btnSairM.Location = new Point(327, 277);
            btnSairM.Name = "btnSairM";
            btnSairM.Size = new Size(94, 39);
            btnSairM.TabIndex = 1;
            btnSairM.Text = "Sair";
            btnSairM.UseVisualStyleBackColor = true;
            btnSairM.Click += btnSairM_Click;
            // 
            // txtCodMotor
            // 
            txtCodMotor.Location = new Point(120, 71);
            txtCodMotor.Name = "txtCodMotor";
            txtCodMotor.Size = new Size(125, 27);
            txtCodMotor.TabIndex = 2;
            // 
            // txtMatMotor
            // 
            txtMatMotor.Location = new Point(386, 128);
            txtMatMotor.Name = "txtMatMotor";
            txtMatMotor.Size = new Size(125, 27);
            txtMatMotor.TabIndex = 3;
            // 
            // txtPropMotor
            // 
            txtPropMotor.Location = new Point(120, 128);
            txtPropMotor.Name = "txtPropMotor";
            txtPropMotor.Size = new Size(125, 27);
            txtPropMotor.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 74);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 7;
            label1.Text = "Codinome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 131);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 8;
            label2.Text = "Propelente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 131);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 9;
            label3.Text = "Material:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 236);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 10;
            label4.Text = "Fabricação:";
            // 
            // lblMotor
            // 
            lblMotor.AutoSize = true;
            lblMotor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMotor.Location = new Point(147, 21);
            lblMotor.Name = "lblMotor";
            lblMotor.Size = new Size(263, 23);
            lblMotor.TabIndex = 11;
            lblMotor.Text = "Coloque as informações abaixo:";
            // 
            // dateTimeMotor
            // 
            dateTimeMotor.Location = new Point(185, 233);
            dateTimeMotor.Name = "dateTimeMotor";
            dateTimeMotor.Size = new Size(250, 27);
            dateTimeMotor.TabIndex = 12;
            // 
            // txtClasseMotor
            // 
            txtClasseMotor.Location = new Point(386, 71);
            txtClasseMotor.Name = "txtClasseMotor";
            txtClasseMotor.Size = new Size(125, 27);
            txtClasseMotor.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 74);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 14;
            label5.Text = "Classe:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(265, 185);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 15;
            label6.Text = "Massa Pós teste:";
            // 
            // txtMVMotor
            // 
            txtMVMotor.Location = new Point(386, 182);
            txtMVMotor.Name = "txtMVMotor";
            txtMVMotor.Size = new Size(125, 27);
            txtMVMotor.TabIndex = 16;
            // 
            // txtMassaMotor
            // 
            txtMassaMotor.Location = new Point(120, 182);
            txtMassaMotor.Name = "txtMassaMotor";
            txtMassaMotor.Size = new Size(125, 27);
            txtMassaMotor.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 185);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 18;
            label7.Text = "Massa:";
            // 
            // FormMotor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 337);
            Controls.Add(label7);
            Controls.Add(txtMassaMotor);
            Controls.Add(txtMVMotor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtClasseMotor);
            Controls.Add(dateTimeMotor);
            Controls.Add(lblMotor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPropMotor);
            Controls.Add(txtMatMotor);
            Controls.Add(txtCodMotor);
            Controls.Add(btnSairM);
            Controls.Add(btnAddM);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMotor";
            Text = "Motor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddM;
        private Button btnSairM;
        private TextBox txtCodMotor;
        private TextBox txtMatMotor;
        private TextBox txtPropMotor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblMotor;
        private DateTimePicker dateTimeMotor;
        private TextBox txtClasseMotor;
        private Label label5;
        private Label label6;
        private TextBox txtMVMotor;
        private TextBox txtMassaMotor;
        private Label label7;
    }
}