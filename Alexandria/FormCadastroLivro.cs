using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Alexandria
{
    public partial class FormCadastroLivro : Form
    {
        public Livros? NovoLivro { get; private set; }
        public bool Excluir { get; private set; }
        private int _idEdicao = 0;

        public FormCadastroLivro()
        {
            InitializeComponent();
            btnSalvar.Click += btnSalvar_Click;
            btnCancelar.Click += btnCancelar_Click;
            cboGenero.DropDownStyle = ComboBoxStyle.DropDown;
            cboGenero.Items.AddRange(new string[] { "Romance", "Mistério", "Fantasia" });
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Items.AddRange(new string[] { "Quero ler", "Estou lendo", "Lido", "Em pausa", "Desisti" });
            cboStatus.SelectedIndex = 0;
            cboStatus.SelectedIndexChanged += (s, e) => AtualizarCamposLido();
            AtualizarCamposLido();
        }
        public FormCadastroLivro(Livros livroExistente) : this()
        {
            _idEdicao = livroExistente.id;
            txtTitulo.Text = livroExistente.titulo;
            textAutor.Text = livroExistente.autor;
            cboGenero.Text = livroExistente.genero;
            txtNota.Text = livroExistente.nota.ToString(CultureInfo.CurrentCulture); 
            txtResenha.Text = livroExistente.resenha;
            cboStatus.SelectedItem = livroExistente.status;
            AtualizarCamposLido();   
            this.Text = "Editar livro";
            Button btnExcluir = new Button();
            btnExcluir.Text = "Excluir";
            btnExcluir.Size = btnCancelar.Size;
            btnExcluir.Location = new Point(btnCancelar.Right + 10, btnCancelar.Top);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.BackColor = Color.FromArgb(180, 50, 60);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Font = btnCancelar.Font;
            btnExcluir.Click += btnExcluir_Click;
            btnCancelar.Parent.Controls.Add(btnExcluir);
        }

        private bool StatusEhLido()
        {
            return cboStatus.Text.Trim().Equals("Lido", StringComparison.OrdinalIgnoreCase);
        }

        private void AtualizarCamposLido()
        {
            bool lido = StatusEhLido();
            txtNota.Enabled = lido;
            txtResenha.Enabled = lido;
            if (!lido)
            {
                txtNota.Text = "";
                txtResenha.Text = "";
            }
        }

        private void FormCadastroLivro_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (string g in BancoLivros.ListarGeneros())
                {
                    if (!cboGenero.Items.Contains(g))
                    {
                        cboGenero.Items.Add(g);
                    }
                }
            }
            catch
            {
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textAutor_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnExcluir_Click(object? sender, EventArgs e)
        {
            var r = MessageBox.Show("Deseja excluir este livro?", "Confirmar",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r != DialogResult.Yes) return;
            Excluir = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSalvar_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(textAutor.Text))
            {
                MessageBox.Show("Informe o título e o autor do livro.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool lido = StatusEhLido();
            double nota = 0;
            if (lido && (!double.TryParse(txtNota.Text, out nota) || nota < 0 || nota > 5))
            {
                MessageBox.Show("A avaliação deve ser um número entre 0 e 5.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string resenha = lido ? txtResenha.Text.Trim() : "";
            string genero = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cboGenero.Text.Trim().ToLower());
            if (!string.IsNullOrWhiteSpace(genero))
            {
                try
                {
                    BancoLivros.AdicionarGenero(genero);
                }
                catch
                {
                }
            }
            NovoLivro = new Livros
            {
                id = _idEdicao,
                titulo = txtTitulo.Text.Trim(),
                autor = textAutor.Text.Trim(),
                genero = genero,
                status = cboStatus.Text.Trim(),
                nota = nota,
                resenha = resenha
            };

            DialogResult = DialogResult.OK;
            Close();
        }
        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
        }
    }
}