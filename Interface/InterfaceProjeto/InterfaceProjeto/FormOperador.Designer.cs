namespace InterfaceProjeto
{
    partial class FormOperador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperador));
            btnAddOp = new Button();
            btnSairOp = new Button();
            txtNomeOp = new TextBox();
            txtCargoOp = new TextBox();
            lblOperador = new Label();
            lblNomeOp = new Label();
            lblCargoOp = new Label();
            SuspendLayout();
            // 
            // btnAddOp
            // 
            btnAddOp.Location = new Point(45, 172);
            btnAddOp.Name = "btnAddOp";
            btnAddOp.Size = new Size(93, 39);
            btnAddOp.TabIndex = 0;
            btnAddOp.Text = "Adicionar";
            btnAddOp.UseVisualStyleBackColor = true;
            btnAddOp.Click += btnAddOp_Click;
            // 
            // btnSairOp
            // 
            btnSairOp.Location = new Point(176, 172);
            btnSairOp.Name = "btnSairOp";
            btnSairOp.Size = new Size(93, 39);
            btnSairOp.TabIndex = 1;
            btnSairOp.Text = "Sair";
            btnSairOp.UseVisualStyleBackColor = true;
            btnSairOp.Click += btnSairOp_Click;
            // 
            // txtNomeOp
            // 
            txtNomeOp.Location = new Point(106, 68);
            txtNomeOp.Name = "txtNomeOp";
            txtNomeOp.Size = new Size(154, 27);
            txtNomeOp.TabIndex = 2;
            // 
            // txtCargoOp
            // 
            txtCargoOp.Location = new Point(106, 117);
            txtCargoOp.Name = "txtCargoOp";
            txtCargoOp.Size = new Size(154, 27);
            txtCargoOp.TabIndex = 3;
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperador.Location = new Point(30, 28);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(263, 23);
            lblOperador.TabIndex = 4;
            lblOperador.Text = "Coloque as informações abaixo:";
            // 
            // lblNomeOp
            // 
            lblNomeOp.AutoSize = true;
            lblNomeOp.Location = new Point(47, 71);
            lblNomeOp.Name = "lblNomeOp";
            lblNomeOp.Size = new Size(53, 20);
            lblNomeOp.TabIndex = 5;
            lblNomeOp.Text = "Nome:";
            // 
            // lblCargoOp
            // 
            lblCargoOp.AutoSize = true;
            lblCargoOp.Location = new Point(48, 120);
            lblCargoOp.Name = "lblCargoOp";
            lblCargoOp.Size = new Size(52, 20);
            lblCargoOp.TabIndex = 6;
            lblCargoOp.Text = "Cargo:";
            // 
            // FormOperador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 245);
            Controls.Add(lblCargoOp);
            Controls.Add(lblNomeOp);
            Controls.Add(lblOperador);
            Controls.Add(txtCargoOp);
            Controls.Add(txtNomeOp);
            Controls.Add(btnSairOp);
            Controls.Add(btnAddOp);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormOperador";
            Text = "Operador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddOp;
        private Button btnSairOp;
        private TextBox txtNomeOp;
        private TextBox txtCargoOp;
        private Label lblOperador;
        private Label lblNomeOp;
        private Label lblCargoOp;
    }
}