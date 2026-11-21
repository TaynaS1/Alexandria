namespace Alexandria
{
    partial class Inicio
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBusca = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pnlTopo = new Panel();
            pnlBanner = new Panel();
            flwLivros = new FlowLayoutPanel();
            label5 = new Label();
            label4 = new Label();
            btnNovoLivro = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTopo.SuspendLayout();
            pnlBanner.SuspendLayout();
            SuspendLayout();

            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(textBusca);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 81);
            panel2.MaximumSize = new Size(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 45);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;

            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(860, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;

            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;

            textBusca.BackColor = Color.FromArgb(38, 27, 60);
            textBusca.BorderStyle = BorderStyle.None;
            textBusca.Location = new Point(614, 12);
            textBusca.Name = "textBusca";
            textBusca.PlaceholderText = "Pesquisar livros";
            textBusca.Size = new Size(240, 18);
            textBusca.TabIndex = 2;
            textBusca.TabStop = false;
            textBusca.TextChanged += textPesquisa_TextChanged;

            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 12);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 2;
            label3.Text = "Início";
            label3.Click += label3_Click;

            panel3.BackColor = Color.Indigo;
            panel3.Location = new Point(1, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(999, 1);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;

            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(68, 18);
            label1.Name = "label1";
            label1.Size = new Size(129, 31);
            label1.TabIndex = 0;
            label1.Text = "Alexandria";
            label1.Click += label1_Click;

            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(169, 155, 196);
            label2.Location = new Point(68, 46);
            label2.Name = "label2";
            label2.Size = new Size(190, 24);
            label2.TabIndex = 1;
            label2.Text = "Sua biblioteca pessoal";

            panel1.BackColor = Color.FromArgb(139, 92, 246);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 50);
            panel1.TabIndex = 1;

            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;

            pnlTopo.AutoScroll = true;
            pnlTopo.Controls.Add(panel3);
            pnlTopo.Controls.Add(panel1);
            pnlTopo.Controls.Add(label2);
            pnlTopo.Controls.Add(label1);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(0, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(1000, 81);
            pnlTopo.TabIndex = 0;
            pnlTopo.Paint += pnlTopo_Paint;

            pnlBanner.BackColor = Color.FromArgb(38, 26, 53);
            pnlBanner.Controls.Add(flwLivros);
            pnlBanner.Controls.Add(label5);
            pnlBanner.Controls.Add(label4);
            pnlBanner.Location = new Point(20, 155);
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new Size(960, 489);
            pnlBanner.TabIndex = 2;

            flwLivros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flwLivros.AutoScroll = true;
            flwLivros.BackColor = Color.Transparent;
            flwLivros.Location = new Point(24, 87);
            flwLivros.Margin = new Padding(0);
            flwLivros.Name = "flwLivros";
            flwLivros.Size = new Size(886, 379);
            flwLivros.TabIndex = 2;
            flwLivros.Paint += flwLivros_Paint;

            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(190, 180, 205);
            label5.Location = new Point(20, 50);
            label5.Name = "label5";
            label5.Size = new Size(414, 24);
            label5.TabIndex = 1;
            label5.Text = "Organize, descubra e guarde seus livros favoritos.";
            label5.Click += label5_Click;

            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 18F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(185, 145, 235);
            label4.Location = new Point(17, 13);
            label4.Name = "label4";
            label4.Size = new Size(166, 35);
            label4.TabIndex = 0;
            label4.Text = "Sua Estante";

            btnNovoLivro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovoLivro.BackColor = Color.FromArgb(139, 92, 246);
            btnNovoLivro.Cursor = Cursors.Hand;
            btnNovoLivro.FlatAppearance.BorderSize = 0;
            btnNovoLivro.FlatAppearance.MouseDownBackColor = Color.FromArgb(110, 70, 210);
            btnNovoLivro.FlatAppearance.MouseOverBackColor = Color.FromArgb(160, 124, 248);
            btnNovoLivro.FlatStyle = FlatStyle.Flat;
            btnNovoLivro.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovoLivro.ForeColor = Color.White;
            btnNovoLivro.Location = new Point(830, 652);
            btnNovoLivro.Name = "btnNovoLivro";
            btnNovoLivro.Size = new Size(150, 32);
            btnNovoLivro.TabIndex = 0;
            btnNovoLivro.Text = "+Livro";
            btnNovoLivro.UseVisualStyleBackColor = false;
            btnNovoLivro.Click += btnNovoLivro_Click;

            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 14, 26);
            ClientSize = new Size(1000, 700);
            Controls.Add(btnNovoLivro);
            Controls.Add(pnlBanner);
            Controls.Add(panel2);
            Controls.Add(pnlTopo);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alexandria";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTopo.ResumeLayout(false);
            pnlTopo.PerformLayout();
            pnlBanner.ResumeLayout(false);
            pnlBanner.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox textBusca;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel pnlTopo;
        private Panel panel3;
        private Panel pnlBanner;
        private Label label4;
        private Label label5;
        private FlowLayoutPanel flwLivros;
        private Label label3;
        private Button btnNovoLivro;
    }
}