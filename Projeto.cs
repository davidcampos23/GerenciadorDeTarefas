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
    public partial class Projeto : Form
    {

        private bool isDragging = false;
        private Point startPoint;

        public Projeto()
        {
            InitializeComponent();

            label2.MouseDown += label2_MouseDown;
            label2.MouseMove += label2_MouseMove;
            label2.MouseUp += label2_MouseUp;
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && e.Button == MouseButtons.Left)
            {
                label2.Left += e.X - startPoint.X;
                label2.Top += e.Y - startPoint.Y;
            }
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CriarT_Click(object sender, EventArgs e)
        {
            NovoProjeto np = new NovoProjeto();
            np.nomeTarefa = "A";
            np.descTarefa = "A";
            Banco.criarTarefas(np);
        }

        private void ExcluirT_Click(object sender, EventArgs e)
        {
            Banco.excluirTarefa("A");
        }
    }
}
