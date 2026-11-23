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

        public Inicio()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            flwLivros.AutoScroll = true;
            flwLivros.WrapContents = true;
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
        public void AdciconarLivro(Livros livro)
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
            int cheias = (int)Math.Round(nota, MidpointRounding.AwayFromZero);
            if (cheias < 0) cheias = 0;
            if (cheias > 5) cheias = 5;
            return new string('★', cheias) + new string('☆', 5 - cheias);
        }
        private void CarregarLivros(string filtro = "")
        {
            flwLivros.Controls.Clear();
            ToolTip dica = new ToolTip();
            foreach (Livros livro in listaLivros)
            {
                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    bool achou = Contem(livro.titulo, filtro)|| Contem(livro.autor, filtro)|| Contem(livro.genero, filtro)||Contem(livro.status, filtro);
                    if (!achou) continue;
                }

                Panel card = new Panel();
                card.Width = 170;
                card.Height = 190;
                card.Margin = new Padding(10);
                card.BorderStyle = BorderStyle.FixedSingle;

                Label titulo = new Label();
                titulo.Text = livro.titulo;
                titulo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                titulo.ForeColor = Color.White;
                titulo.Location = new Point(10, 10);
                titulo.Size = new Size(150, 40);

                Label autor = new Label();
                autor.Text = livro.autor;
                autor.ForeColor = Color.White;
                autor.Location = new Point(10, 50);
                autor.Size = new Size(150, 20);

                Label generoStatus = new Label();
                generoStatus.Text = livro.genero + " • " + livro.status;
                generoStatus.ForeColor = Color.White;
                generoStatus.Location = new Point(10, 75);
                generoStatus.Size = new Size(150, 20);

                Label nota = new Label();
                nota.Text = GerarEstrelas(livro.nota);
                nota.Font = new Font("Segoe UI Symbol", 12);
                nota.ForeColor = Color.Goldenrod;
                nota.Location = new Point(10, 98);
                nota.Size = new Size(150, 25);

                Label resenha = new Label();
                resenha.Text = livro.resenha;
                resenha.ForeColor = Color.FromArgb(201, 184, 224);
                resenha.AutoEllipsis = true;
                resenha.Location = new Point(10, 128);
                resenha.Size = new Size(150, 52);

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
        }

        private static bool Contem(string? texto, string busca)
        {
            return CultureInfo.CurrentCulture.CompareInfo.IndexOf(
                texto ?? "", busca.Trim(),CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) >= 0;
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
            var r = MessageBox.Show("Deseja excluir \"" + livro.titulo + "\"?", "Confirmar",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
    }
}