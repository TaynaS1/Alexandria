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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroLivro));
            pnlLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            cboStatus = new ComboBox();
            cboGenero = new ComboBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtNota = new TextBox();
            textAutor = new TextBox();
            txtResenha = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtAutor = new Label();
            txtTitulo = new TextBox();
            label4 = new Label();
            label2 = new Label();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(139, 92, 246);
            pnlLogo.Controls.Add(pictureBox1);
            pnlLogo.Location = new Point(12, 12);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(50, 50);
            pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(139, 92, 246);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 26, 53);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cboStatus);
            panel1.Controls.Add(cboGenero);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(txtNota);
            panel1.Controls.Add(textAutor);
            panel1.Controls.Add(txtResenha);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtAutor);
            panel1.Controls.Add(txtTitulo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 453);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint_1;
            // 
            // cboStatus
            // 
            cboStatus.BackColor = Color.FromArgb(31, 22, 48);
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FlatStyle = FlatStyle.Flat;
            cboStatus.ForeColor = Color.White;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(160, 219);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(244, 24);
            cboStatus.TabIndex = 16;
            // 
            // cboGenero
            // 
            cboGenero.BackColor = Color.FromArgb(31, 22, 48);
            cboGenero.FlatStyle = FlatStyle.Flat;
            cboGenero.ForeColor = Color.White;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(105, 169);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(299, 24);
            cboGenero.TabIndex = 15;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(31, 22, 48);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(179, 136, 235);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 42, 82);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(26, 391);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 24);
            btnCancelar.TabIndex = 8;
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
            btnSalvar.Location = new Point(26, 362);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // txtNota
            // 
            txtNota.BackColor = Color.FromArgb(31, 22, 48);
            txtNota.BorderStyle = BorderStyle.FixedSingle;
            txtNota.ForeColor = Color.White;
            txtNota.Location = new Point(105, 264);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(299, 22);
            txtNota.TabIndex = 12;
            // 
            // textAutor
            // 
            textAutor.BackColor = Color.FromArgb(31, 22, 48);
            textAutor.BorderStyle = BorderStyle.FixedSingle;
            textAutor.ForeColor = Color.White;
            textAutor.Location = new Point(105, 132);
            textAutor.Name = "textAutor";
            textAutor.Size = new Size(299, 22);
            textAutor.TabIndex = 10;
            // 
            // txtResenha
            // 
            txtResenha.BackColor = Color.FromArgb(31, 22, 48);
            txtResenha.BorderStyle = BorderStyle.FixedSingle;
            txtResenha.ForeColor = Color.White;
            txtResenha.Location = new Point(105, 312);
            txtResenha.Name = "txtResenha";
            txtResenha.Size = new Size(299, 22);
            txtResenha.TabIndex = 9;
            txtResenha.TextChanged += textAutor_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 12F);
            label9.Location = new Point(25, 268);
            label9.Name = "label9";
            label9.Size = new Size(80, 18);
            label9.TabIndex = 8;
            label9.Text = "Avaliação:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 12F);
            label8.Location = new Point(25, 313);
            label8.Name = "label8";
            label8.Size = new Size(73, 18);
            label8.TabIndex = 7;
            label8.Text = "Resenha:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 12F);
            label7.Location = new Point(25, 223);
            label7.Name = "label7";
            label7.Size = new Size(135, 18);
            label7.TabIndex = 6;
            label7.Text = "Status da Leitura:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 12F);
            label6.Location = new Point(25, 178);
            label6.Name = "label6";
            label6.Size = new Size(65, 18);
            label6.TabIndex = 5;
            label6.Text = "Gênero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 160);
            label5.Name = "label5";
            label5.Size = new Size(0, 16);
            label5.TabIndex = 4;
            // 
            // txtAutor
            // 
            txtAutor.AutoSize = true;
            txtAutor.Font = new Font("Georgia", 12F);
            txtAutor.Location = new Point(25, 133);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(54, 18);
            txtAutor.TabIndex = 3;
            txtAutor.Text = "Autor:";
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.FromArgb(31, 22, 48);
            txtTitulo.BorderStyle = BorderStyle.FixedSingle;
            txtTitulo.ForeColor = Color.White;
            txtTitulo.Location = new Point(105, 84);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(299, 22);
            txtTitulo.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 88);
            label4.Name = "label4";
            label4.Size = new Size(55, 18);
            label4.TabIndex = 1;
            label4.Text = "Título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 38);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 0;
            label2.Text = "CADASTRO";
            label2.Click += label2_Click_1;
            // 
            // FormCadastroLivro
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 16, 26);
            ClientSize = new Size(490, 567);
            Controls.Add(panel1);
            Controls.Add(pnlLogo);
            Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormCadastroLivro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Livro ";
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogo;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label4;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label txtAutor;
        private TextBox txtTitulo;
        private TextBox txtResenha;
        private Label label9;
        private TextBox textAutor;
        private TextBox txtNota;
        private Button btnSalvar;
        private Button btnCancelar;
        private ComboBox cboGenero;
        private ComboBox cboStatus;
    }
}