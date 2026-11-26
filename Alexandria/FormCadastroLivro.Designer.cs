namespace Alexandria
{
    partial class FormCadastroLivro
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
            panel1 = new Panel();
            txtResenha = new TextBox();
            label7 = new Label();
            txtNota = new TextBox();
            label6 = new Label();
            cboStatus = new ComboBox();
            label3 = new Label();
            cboGenero = new ComboBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            textAutor = new TextBox();
            label5 = new Label();
            label = new Label();
            txtTitulo = new TextBox();
            label4 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 26, 53);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtResenha);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtNota);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cboStatus);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboGenero);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(textAutor);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label);
            panel1.Controls.Add(txtTitulo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(28, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 426);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // txtResenha
            // 
            txtResenha.BackColor = Color.FromArgb(31, 22, 48);
            txtResenha.BorderStyle = BorderStyle.FixedSingle;
            txtResenha.ForeColor = Color.White;
            txtResenha.Location = new Point(110, 296);
            txtResenha.Name = "txtResenha";
            txtResenha.Size = new Size(299, 23);
            txtResenha.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(25, 301);
            label7.Name = "label7";
            label7.Size = new Size(73, 18);
            label7.TabIndex = 22;
            label7.Text = "Resenha:";
            // 
            // txtNota
            // 
            txtNota.BackColor = Color.FromArgb(31, 22, 48);
            txtNota.BorderStyle = BorderStyle.FixedSingle;
            txtNota.ForeColor = Color.White;
            txtNota.Location = new Point(110, 255);
            txtNota.Name = "txtNota";
            txtNota.PlaceholderText = "0 a 5 estrelas";
            txtNota.ScrollBars = ScrollBars.Vertical;
            txtNota.Size = new Size(299, 23);
            txtNota.TabIndex = 21;
            txtNota.Text = " 0 a 5 estrelas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(25, 260);
            label6.Name = "label6";
            label6.Size = new Size(80, 18);
            label6.TabIndex = 20;
            label6.Text = "Avaliação:";
            label6.Click += label6_Click;
            // 
            // cboStatus
            // 
            cboStatus.BackColor = Color.FromArgb(38, 26, 53);
            cboStatus.FlatStyle = FlatStyle.Flat;
            cboStatus.ForeColor = Color.White;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(166, 211);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(243, 23);
            cboStatus.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 216);
            label3.Name = "label3";
            label3.Size = new Size(135, 18);
            label3.TabIndex = 18;
            label3.Text = "Status de Leitura:";
            label3.Click += label3_Click;
            // 
            // cboGenero
            // 
            cboGenero.BackColor = Color.FromArgb(38, 26, 53);
            cboGenero.FlatStyle = FlatStyle.Flat;
            cboGenero.ForeColor = Color.White;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(110, 165);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(299, 23);
            cboGenero.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 170);
            label1.Name = "label1";
            label1.Size = new Size(65, 18);
            label1.TabIndex = 16;
            label1.Text = "Gênero:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(31, 22, 48);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(179, 136, 235);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 42, 82);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(6, 374);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 24);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(139, 92, 246);
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(160, 124, 248);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(6, 345);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // textAutor
            // 
            textAutor.BackColor = Color.FromArgb(31, 22, 48);
            textAutor.BorderStyle = BorderStyle.FixedSingle;
            textAutor.ForeColor = Color.White;
            textAutor.Location = new Point(110, 122);
            textAutor.Name = "textAutor";
            textAutor.Size = new Size(299, 23);
            textAutor.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 160);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Georgia", 12F);
            label.ForeColor = Color.White;
            label.Location = new Point(25, 127);
            label.Name = "label";
            label.Size = new Size(54, 18);
            label.TabIndex = 3;
            label.Text = "Autor:";
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.FromArgb(31, 22, 48);
            txtTitulo.BorderStyle = BorderStyle.FixedSingle;
            txtTitulo.ForeColor = Color.White;
            txtTitulo.Location = new Point(110, 83);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(299, 23);
            txtTitulo.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 88);
            label4.Name = "label4";
            label4.Size = new Size(55, 18);
            label4.TabIndex = 1;
            label4.Text = "Título:";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 38);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 0;
            label2.Text = "CADASTRO";
            // 
            // FormCadastroLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 16, 26);
            ClientSize = new Size(617, 450);
            Controls.Add(panel1);
            Name = "FormCadastroLivro";
            Text = "FormCadastroLivro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox textAutor;
        private Label label5;
        private Label label;
        private TextBox txtTitulo;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox cboGenero;
        private Label label3;
        private ComboBox cboStatus;
        private Label label6;
        private Label label7;
        private TextBox txtNota;
        private TextBox txtResenha;
    }
}