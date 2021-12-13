using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoProfissional.Entities;
using CursoProfissional.Model;

namespace CursoProfissional
{
    public partial class FormUtilizador : Form
    {
        ModelUtilizador modelUtilizador = new ModelUtilizador();

        public FormUtilizador()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Utilizador utilizador = new Utilizador();
            EntrarFU(utilizador);
        }

        internal void EntrarFU(Utilizador utilizador)
        {
            try
            {

                if (txtLogin.Text == "")
                {
                    lblMensagem.Text = "O utilizador não pode estar vazio!";
                    lblMensagem.ForeColor = Color.Red;
                    txtLogin.Focus();
                    return;
                }

                if (txtPassword.Text == "")
                {
                    lblMensagem.Text = "A palavra-passe não pode estar vazia!";
                    lblMensagem.ForeColor = Color.Red;
                    txtPassword.Focus();
                    return;
                }

                utilizador.Login = txtLogin.Text;
                utilizador.Password = txtPassword.Text;
                utilizador = modelUtilizador.EntrarMU(utilizador);

                if (utilizador.Login == null)
                {
                    lblMensagem.Text = "Utilizador ou password incorretos!";
                    lblMensagem.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    FormMain formMain = new FormMain();
                    this.Hide();
                    formMain.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao entrar!" + ex.Message);
            }
        }
    }
}
