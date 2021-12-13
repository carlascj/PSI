using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoProfissional
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void miDisciplina_Click(object sender, EventArgs e)
        {
            FormDisciplina formDisciplina = new FormDisciplina();
            formDisciplina.ShowDialog();
            Show();
        }

        private void miSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
