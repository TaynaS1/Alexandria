using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Alexandria
{
    public partial class Inicio : Form
    {
        private List<Livros> listaLivros = new List<Livros>();
        private string _filtroAtual = "";

        public Inicio()//prepara a tela
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)//tela pronta
        {
            flwLivros.AutoScroll = true;
            flwLivros.WrapContents = true;

            flwLivros.Resize += (s, ev) => AjustarLarguraCards();

            try
            {
                listaLivros = BancoLivros.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar os livros do banco: " + ex.Message);
            }
            CarregarLivros();
        }
        public void AdciconarLivro(Livros livro)//livro adicionado
        {
            try
            {
                BancoLivros.Inserir(livro);
                listaLivros = BancoLivros.Listar();
                CarregarLivros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar no banco: " + ex.Message);
            }
        }
        private string GerarEstrelas(double nota)
        {
            int cheias = (int)Math.Round(nota, MidpointRounding.AwayFromZero);//areedonda
            if (cheias < 0) cheias = 0;
            if (cheias > 5) cheias = 5;
            return new string('★', cheias) + new string('☆', 5 - cheias);//faltam
        }

        private int CalcularLarguraCard(Padding margem)//calcula
        {
            int largura = flwLivros.ClientSize.Width - margem.Horizontal - SystemInformation.VerticalScrollBarWidth;
            return Math.Max(largura, 170);
        }

        private void AjustarLarguraCards()//aplica
        {
            flwLivros.SuspendLayout();
            foreach (Control c in flwLivros.Controls)
            {
                if (c is Panel card)
                {
                    card.Width = CalcularLarguraCard(card.Margin);
                }
            }
            flwLivros.ResumeLayout();
        }

        private void CarregarLivros(string filtro = "")
        {
            flwLivros.SuspendLayout();
            flwLivros.Controls.Clear();
            ToolTip dica = new ToolTip();
            foreach (Livros livro in listaLivros)//percorre os livros
            {
                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    bool achou = livro.titulo.StartsWith(filtro.Trim(), StringComparison.OrdinalIgnoreCase);
                    if (!achou) continue;
                }

                Panel card = new Panel();
                card.Margin = new Padding(10);
                card.Width = CalcularLarguraCard(card.Margin);
                card.Height = 190;
                card.BorderStyle = BorderStyle.FixedSingle;

                int larguraInterna = card.Width - 20;
                AnchorStyles ancora = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                Label titulo = new Label();
                titulo.Text = livro.titulo;
                titulo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                titulo.ForeColor = Color.White;
                titulo.Location = new Point(10, 10);
                titulo.Size = new Size(larguraInterna, 40);
                titulo.Anchor = ancora;

                Label autor = new Label();
                autor.Text = livro.autor;
                autor.ForeColor = Color.White;
                autor.Location = new Point(10, 50);
                autor.Size = new Size(larguraInterna, 20);
                autor.Anchor = ancora;

                Label generoStatus = new Label();
                generoStatus.Text = livro.genero + " • " + livro.status;
                generoStatus.ForeColor = Color.White;
                generoStatus.Location = new Point(10, 75);
                generoStatus.Size = new Size(larguraInterna, 20);
                generoStatus.Anchor = ancora;

                Label nota = new Label();
                nota.Text = GerarEstrelas(livro.nota);
                nota.Font = new Font("Segoe UI Symbol", 12);
                nota.ForeColor = Color.Goldenrod;
                nota.Location = new Point(10, 98);
                nota.Size = new Size(larguraInterna, 25);
                nota.Anchor = ancora;

                Label resenha = new Label();
                resenha.Text = livro.resenha;
                resenha.ForeColor = Color.FromArgb(201, 184, 224);
                resenha.AutoEllipsis = true;
                resenha.Location = new Point(10, 128);
                resenha.Size = new Size(larguraInterna, 52);
                resenha.Anchor = ancora;

                card.Controls.Add(titulo);
                card.Controls.Add(autor);
                card.Controls.Add(generoStatus);
                card.Controls.Add(nota);
                card.Controls.Add(resenha);

                if (!string.IsNullOrWhiteSpace(livro.resenha))
                {
                    dica.SetToolTip(card, livro.resenha);
                    dica.SetToolTip(resenha, livro.resenha);
                }
                var menu = new ContextMenuStrip();
                menu.Items.Add("Editar", null, (s, e) => EditarLivro(livro));
                menu.Items.Add("Excluir", null, (s, e) => ExcluirLivro(livro));
                card.Cursor = Cursors.Hand;
                card.ContextMenuStrip = menu;
                card.Click += (s, e) => EditarLivro(livro);
                foreach (Control filho in card.Controls)
                {
                    filho.Cursor = Cursors.Hand;
                    filho.ContextMenuStrip = menu;
                    filho.Click += (s, e) => EditarLivro(livro);
                }
                flwLivros.Controls.Add(card);
            }
            if (flwLivros.Controls.Count == 0 && !string.IsNullOrWhiteSpace(filtro))
            {
                Label vazio = new Label();
                vazio.Text = "Nenhum livro encontrado para \"" + filtro.Trim() + "\".";
                vazio.ForeColor = Color.FromArgb(201, 184, 224);
                vazio.AutoSize = true;
                vazio.Margin = new Padding(12);
                flwLivros.Controls.Add(vazio);
            }
            flwLivros.ResumeLayout();
        }

        private static bool Contem(string? texto, string busca)
        {
            return CultureInfo.CurrentCulture.CompareInfo.IndexOf(
                texto ?? "", busca.Trim(), CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) >= 0;
        }

        private void EditarLivro(Livros livro)
        {
            using (var f = new FormCadastroLivro(livro))
            {
                this.Hide();
                f.ShowDialog();
                this.Show();
                try
                {
                    if (f.Excluir)
                    {
                        int apagados = BancoLivros.Excluir(livro.id);
                        if (apagados == 0)
                            MessageBox.Show("Nenhum livro foi excluído no banco (id = " + livro.id + ").");
                        listaLivros = BancoLivros.Listar();
                        CarregarLivros(_filtroAtual);
                    }
                    else if (f.NovoLivro != null)
                    {
                        BancoLivros.Atualizar(f.NovoLivro);
                        listaLivros = BancoLivros.Listar();
                        CarregarLivros(_filtroAtual);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
        private void ExcluirLivro(Livros livro)
        {
            var r = MessageBox.Show("Deseja excluir \"" + livro.titulo + "\"?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r != DialogResult.Yes) return;

            try
            {
                int apagados = BancoLivros.Excluir(livro.id);
                if (apagados == 0)
                    MessageBox.Show("Nenhum livro foi excluído no banco (id = " + livro.id + ").");
                listaLivros = BancoLivros.Listar();
                CarregarLivros(_filtroAtual);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }

        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {
            _filtroAtual = ((TextBox)sender).Text;
            CarregarLivros(_filtroAtual);
        }

        private void btnNovoLivro_Click(object sender, EventArgs e)
        {
            FormCadastroLivro cadastro = new FormCadastroLivro();
            this.Hide();
            cadastro.ShowDialog();
            if (cadastro.NovoLivro != null)
            {
                AdciconarLivro(cadastro.NovoLivro);
            }
            this.Show();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            logarUsuario telaLogin = new logarUsuario();
            telaLogin.FormClosed += (s, args) => this.Show();
            telaLogin.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
        private void pnlTopo_Paint(object sender, PaintEventArgs e)
        {
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void flwLivros_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            logarUsuario telaLogin = new logarUsuario();
            telaLogin.FormClosed += (s, args) => this.Show();
            telaLogin.Show();
            this.Hide();
        }
    }
}