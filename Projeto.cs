using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTarefas
{
    public partial class Projeto : Form
    {
        //Mover Tarefas na Tela
        private bool isDragging = false;
        private Point startPoint;

        //TextBox que cria uma nova tarefa
        TextBox newTaf = new TextBox();
        //TextBoc que exclui uma Tarefa
        TextBox delTaf = new TextBox();

        //Limitardor de TextBox
        private bool tbxNew = false;
        private bool tbxDel = false;

        //valor da fk da tabela de tarefas
        int fk;
        DataTable dt = new DataTable();

        public Projeto(int idProjeto)
        {
            InitializeComponent();

            fk = idProjeto;
            iniciandoProjeto();
            mostrarTarefas();
        }

        private void iniciandoProjeto()
        {
            string sql = "SELECT nome_Projeto FROM tb_Projetos WHERE id_Projeto = '" + fk + "' ";
            dt = Banco.consulta(sql);
            nomeDoProjeto.Text = dt.Rows[0].Field<string>("nome_Projeto");
        }

        private void tarefa_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void tarefa_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && e.Button == MouseButtons.Left)
            {
                System.Windows.Forms.Label tarefa = (System.Windows.Forms.Label)sender;
                tarefa.BringToFront();

                tarefa.Left += e.X - startPoint.X;
                tarefa.Top += e.Y - startPoint.Y;
            }
        }

        private void tarefa_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            
            System.Windows.Forms.Label tarefa = (System.Windows.Forms.Label)sender;
            string nome = tarefa.Text;
            int novaPosX = tarefa.Left; // Obtém a nova coordenada X
            int novaPosY = tarefa.Top; // Obtém a nova coordenada Y

            Banco.Location(nome, novaPosX, novaPosY);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newTaf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NovoProjeto np = new NovoProjeto();
                np.nomeTarefa = newTaf.Text;
                np.foreingKay = fk;
                Banco.criarTarefas(np);
                this.Controls.Remove(newTaf);
                tbxNew = false;
                Recarregar();
            }

        }

        private void delTaf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Banco.excluirTarefa(delTaf.Text);
                this.Controls.Remove(delTaf);
                tbxDel = false;
                Recarregar();
            }
        }

        private void CriarT_Click(object sender, EventArgs e)
        {
            if (!tbxNew)
            {
                newTaf.Location = new Point(95, 567);
                newTaf.Width = 111;
                newTaf.Height = 23;
                newTaf.Text = "Nome da Tarefa";

                newTaf.KeyDown += newTaf_KeyDown;

                this.Controls.Add(newTaf);
                tbxNew = true;
            }
        }

        private void ExcluirT_Click(object sender, EventArgs e)
        {
            if (!tbxDel)
            {
                delTaf.Location = new Point(95, 612);
                delTaf.Size = new Size(111, 23);
                delTaf.Text = "Deletar Tarefa";

                delTaf.KeyDown += delTaf_KeyDown;

                this.Controls.Add(delTaf);
                tbxDel = true;
            }
        }

        private void mostrarTarefas()
        {
            //Propriedades Label
            int posX = 0;
            int posY = 0;
            int width = 200;
            int height = 30;
            int size = 11;

            int tamanhoA = Banco.tb_QTaf(fk);
            string[] array = new string[tamanhoA];

            string sql = "SELECT * FROM tb_Tarefas WHERE id_projeto = '" + fk + "'";
            dt = Banco.consulta(sql);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = dt.Rows[i].Field<string>("nome_Tarefa");
                System.Windows.Forms.Label tarefa = new System.Windows.Forms.Label();

                tarefa.Text = array[i];
                tarefa.Size = new Size(width, height);
                tarefa.Font = new Font(tarefa.Font.FontFamily, size, tarefa.Font.Style);
                tarefa.BackColor = Color.Transparent;

                if (!dt.Rows[i].IsNull("posX") && !dt.Rows[i].IsNull("posY"))
                {
                    posX = Convert.ToInt32(dt.Rows[i].Field<Int64>("posX"));
                    posY = Convert.ToInt32(dt.Rows[i].Field<Int64>("posY"));

                }

                tarefa.Location = new Point(posX, posY);

                tarefa.MouseDown += tarefa_MouseDown;
                tarefa.MouseMove += tarefa_MouseMove;
                tarefa.MouseUp += tarefa_MouseUp;

                this.Controls.Add(tarefa);

                posX += width + 70;
                if ((i + 1) % 5 == 0)
                {
                    posX = 20;
                    posY += height + 70;
                }

            }
        }

        public void Recarregar()
        {
            for (int i = this.Controls.Count - 1; i >= 12; i--)
            {
                Control controle = this.Controls[i];

                // Verificar se é a label ou um dos botões que você deseja remover
                if (controle is System.Windows.Forms.Label)
                {
                    this.Controls.RemoveAt(i); // Remover o controle
                }
            }
            mostrarTarefas();
        }
    }
}
