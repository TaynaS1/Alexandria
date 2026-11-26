namespace Alexandria
{
    partial class logarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logarUsuario));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            btnCancelar = new Button();
            btnLogar = new Button();
            txtSenhaCadastro = new TextBox();
            label5 = new Label();
            txtAutor = new Label();
            txtEmailCadastro = new TextBox();
            label4 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(139, 92, 246);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 26, 53);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnLogar);
            panel1.Controls.Add(txtSenhaCadastro);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtAutor);
            panel1.Controls.Add(txtEmailCadastro);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 252);
            panel1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(31, 22, 48);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(179, 136, 235);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 42, 82);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(25, 207);
            button1.Name = "button1";
            button1.Size = new Size(75, 24);
            button1.TabIndex = 15;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
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
            // btnLogar
            // 
            btnLogar.BackColor = Color.FromArgb(139, 92, 246);
            btnLogar.Cursor = Cursors.Hand;
            btnLogar.FlatAppearance.BorderSize = 0;
            btnLogar.FlatAppearance.MouseOverBackColor = Color.FromArgb(160, 124, 248);
            btnLogar.FlatStyle = FlatStyle.Flat;
            btnLogar.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogar.ForeColor = Color.White;
            btnLogar.Location = new Point(25, 178);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(75, 23);
            btnLogar.TabIndex = 14;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = false;
            btnLogar.Click += btnLogar_Click;
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.BackColor = Color.FromArgb(31, 22, 48);
            txtSenhaCadastro.BorderStyle = BorderStyle.FixedSingle;
            txtSenhaCadastro.ForeColor = Color.White;
            txtSenhaCadastro.Location = new Point(84, 128);
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.Size = new Size(299, 23);
            txtSenhaCadastro.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 160);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // txtAutor
            // 
            txtAutor.AutoSize = true;
            txtAutor.Font = new Font("Georgia", 12F);
            txtAutor.ForeColor = Color.White;
            txtAutor.Location = new Point(25, 133);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(56, 18);
            txtAutor.TabIndex = 3;
            txtAutor.Text = "Senha:";
            // 
            // txtEmailCadastro
            // 
            txtEmailCadastro.BackColor = Color.FromArgb(31, 22, 48);
            txtEmailCadastro.BorderStyle = BorderStyle.FixedSingle;
            txtEmailCadastro.ForeColor = Color.White;
            txtEmailCadastro.Location = new Point(84, 83);
            txtEmailCadastro.Name = "txtEmailCadastro";
            txtEmailCadastro.Size = new Size(299, 23);
            txtEmailCadastro.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 88);
            label4.Name = "label4";
            label4.Size = new Size(68, 18);
            label4.TabIndex = 1;
            label4.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 38);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 0;
            label2.Text = "LOGIN";
            // 
            // logarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 16, 26);
            ClientSize = new Size(420, 326);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "logarUsuario";
            Text = "logarUsuario";
            Load += logarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnLogar;
        private TextBox txtSenhaCadastro;
        private Label label5;
        private Label txtAutor;
        private TextBox txtEmailCadastro;
        private Label label4;
        private Label label2;
        private Button button1;
    }
}