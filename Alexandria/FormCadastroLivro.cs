using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Alexandria
{
    public partial class FormCadastroLivro : Form
    {
        public Livros? NovoLivro { get; private set; }
        public bool Excluir { get; private set; }
        private int _idEdicao = 0; private readonly Dictionary<string, bool> _permiteNota = new Dictionary<string, bool>(StringComparer.OrdinalIgnoreCase);

        public FormCadastroLivro()
        {
            InitializeComponent();
            btnSalvar.Click += btnSalvar_Click;
            btnCancelar.Click += btnCancelar_Click;
            cboGenero.DropDownStyle = ComboBoxStyle.DropDown;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            CarregarListas();
            cboStatus.SelectedIndexChanged += (s, e) => AtualizarCamposNota();
            if (cboStatus.Items.Count > 0)
                cboStatus.SelectedIndex = 0;
            AtualizarCamposNota();
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
            AtualizarCamposNota();
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
        private void CarregarListas()
        {
            try
            {
                foreach (StatusLeitura s in BancoLivros.ListarStatus())
                {
                    _permiteNota[s.Nome] = s.PermiteNota;
                    cboStatus.Items.Add(s.Nome);
                }
                foreach (string g in BancoLivros.ListarGeneros())
                {
                    cboGenero.Items.Add(g);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar status e gêneros do banco: " + ex.Message);
            }
        }

        private bool StatusPermiteNota()
        {
            return _permiteNota.TryGetValue(cboStatus.Text.Trim(), out bool permite) && permite;
        }

        private void AtualizarCamposNota()
        {
            bool permite = StatusPermiteNota();
            txtNota.Enabled = permite;
            txtResenha.Enabled = permite;
            if (!permite)
            {
                txtNota.Text = "";
                txtResenha.Text = "";
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void textAutor_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnExcluir_Click(object? sender, EventArgs e)
        {
            var r = MessageBox.Show("Deseja excluir este livro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            if (cboStatus.SelectedItem == null)
            {
                MessageBox.Show("Selecione o status da leitura.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool permiteNota = StatusPermiteNota();
            double nota = 0;
            if (permiteNota && (!double.TryParse(txtNota.Text, out nota) || nota < 0 || nota > 5))
            {
                MessageBox.Show("A avaliação deve ser um número entre 0 e 5.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string resenha = permiteNota ? txtResenha.Text.Trim() : "";
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
                id = _idEdicao, titulo = txtTitulo.Text.Trim(),autor = textAutor.Text.Trim(),genero = genero,status = cboStatus.Text.Trim(),nota = nota,resenha = resenha
            };
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}