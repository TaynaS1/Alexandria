using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Alexandria
{
    public partial class logarUsuario : Form
    {
        public logarUsuario()
        {
            InitializeComponent();
        }

        private void logarUsuario_Load(object sender, EventArgs e)
        {
            txtSenhaCadastro.PasswordChar = '*';
        }

        private void txtResenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtEmailCadastro.Text.Trim().Equals("Tay") && txtSenhaCadastro.Text.Equals("12"))
            {
                Inicio telaInicio = new Inicio();
                this.Hide();
                telaInicio.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreta!");
            }
        }
    }
}