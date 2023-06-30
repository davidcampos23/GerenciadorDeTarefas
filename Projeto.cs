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
        private TextBox newTaf;
        //TextBoc que exclui uma Tarefa
        private TextBox delTaf;

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

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newTaf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NovoProjeto np = new NovoProjeto();
                TextBox newTaf = (TextBox)sender;
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
                TextBox delTaf = (TextBox)sender;
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
                if (!this.Controls.Contains(newTaf))
                {
                    newTaf = new TextBox();
                    newTaf.Location = new Point(95, 575);
                    newTaf.Size = new Size(128, 30);
                    newTaf.Text = "Criar Tarefa";
                    newTaf.BackColor = Color.FromArgb(39, 39, 58);
                    newTaf.ForeColor = Color.White;
                    newTaf.BorderStyle = BorderStyle.None;
                    newTaf.Multiline = true;
                    newTaf.Font = new Font(newTaf.Font.FontFamily, 12, newTaf.Font.Style);

                    newTaf.KeyDown += newTaf_KeyDown;

                    this.Controls.Add(newTaf);

                }
                tbxNew = true;
                tbxDel = false;
            }
            else
            {

                this.Controls.Remove(newTaf);
                tbxNew = false;

            }
        }

        private void ExcluirT_Click(object sender, EventArgs e)
        {
            if (!tbxDel)
            {
                delTaf = new TextBox();
                if (!this.Controls.Contains(delTaf))
                {
                    delTaf.Location = new Point(95, 620);
                    delTaf.Width = 128;
                    delTaf.Height = 30;
                    delTaf.Text = "Deletar Tarefa";
                    delTaf.BackColor = Color.FromArgb(39, 39, 58);
                    delTaf.ForeColor = Color.White;
                    delTaf.BorderStyle = BorderStyle.None;
                    delTaf.Multiline = true;
                    delTaf.Font = new Font(delTaf.Font.FontFamily, 12, delTaf.Font.Style);

                    delTaf.KeyDown += delTaf_KeyDown;

                    this.Controls.Add(delTaf);
                }
                tbxDel = true;
                tbxNew = false;
            }
            else
            {
                this.Controls.Remove(delTaf);
                tbxDel = false;
            }

        }

        private void mostrarTarefas()
        {
            //Propriedades Label
            int size = 11;

            int tamanhoA = Banco.tb_QTaf(fk);
            string[] array = new string[tamanhoA];

            string sql = "SELECT * FROM tb_Tarefas WHERE id_projeto = '" + fk + "'";
            dt = Banco.consulta(sql);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = dt.Rows[i].Field<string>("nome_Tarefa");
                System.Windows.Forms.Label tarefa = new System.Windows.Forms.Label();

                tarefa.Name = "tarefa";
                tarefa.Text = array[i];
                tarefa.AutoSize = true;
                tarefa.Width = tarefa.PreferredWidth;
                tarefa.Height = tarefa.PreferredHeight;
                tarefa.Font = new Font(tarefa.Font.FontFamily, size, tarefa.Font.Style);
                //tarefa.BackColor = Color.Transparent;
                tarefa.ForeColor = Color.White;

                tarefa.MouseDown += tarefa_MouseDown;
                tarefa.MouseMove += tarefa_MouseMove;
                tarefa.MouseUp += tarefa_MouseUp;

                if (!dt.Rows[i].IsNull("posX") && !dt.Rows[i].IsNull("posY"))
                {
                    int posXb = Convert.ToInt32(dt.Rows[i].Field<Int64>("posX"));
                    int posYb = Convert.ToInt32(dt.Rows[i].Field<Int64>("posY"));
                    tarefa.Location = new Point(posXb, posYb);
                }
                else
                {
                    int posX = 230;
                    int posY = 550;
                    Point pos = new Point(posX, posY);

                    while (ExisteControleNaPosicao(pos))
                    {
                        posX += tarefa.Width + 30;
                        if (posX >= 950)
                        {
                            posX = tarefa.Height + 230;
                            posY += 20;
                        }
                        pos = new Point(posX, posY);
                    }

                    tarefa.Location = pos;
                }
                this.Controls.Add(tarefa);
                tarefa.BringToFront();
            }
        }

        private bool ExisteControleNaPosicao(Point posicao)
        {
            foreach (Control controle in this.Controls)
            {
                if (controle.Location == posicao)
                {
                    return true;
                }
            }
            return false;
        }

        public void Recarregar()
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control controle = this.Controls[i];

                // Verificar se é a label ou um dos botões que você deseja remover
                if (controle.Name == "tarefa")
                {
                    this.Controls.RemoveAt(i); // Remover o controle
                }
            }
            mostrarTarefas();
        }

        private void Projeto_Load(object sender, EventArgs e)
        {

        }
    }
}
