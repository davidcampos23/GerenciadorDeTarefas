using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTarefas
{
    public partial class ExcluirP : Form
    {
        public ExcluirP()
        {
            InitializeComponent();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bExcluir_Click(object sender, EventArgs e)
        {
            string resposta = textBox1.Text;
            Banco.excluirProjeto(resposta);
            this.Close();
        }

    }
}
