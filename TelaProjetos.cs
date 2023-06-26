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
    public partial class TelaProjetos : Form
    {
        DataTable dt = new DataTable();

        public TelaProjetos()
        {
            InitializeComponent();
            MostrarProjetos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Criar criarP = new Criar();
            criarP.ShowDialog();
            Recarregar();
        }

        private void TelaProjetos_Load(object sender, EventArgs e)
        {

        }

        //Mostra os Projetos Criados
        private void MostrarProjetos()
        {
            //Propriedas Label
            int LposX = 20;
            int LposY = 106;
            int Lwidth = 129;
            int Lheight = 21;
            int LSize = 12;

            //Propriedades TextBox
            int TposX = 20;
            int TposY = 140;
            int Twidth = 173;
            int Theight = 195;
            int Tsize = 11;

            int spacing = 70;
            int columns = 5;


            int tamanhoA = Banco.tb_Rows();
            string[] array = new string[tamanhoA];

            string sql = "SELECT * FROM tb_Projetos";
            dt = Banco.consulta(sql);

            for (int i = 0; i < array.Length; i++)
            {
                //Cria o Nome
                array[i] = dt.Rows[i].Field<string>("nome_Projeto");
                Label label = new Label();

                label.Text = array[i];
                label.Size = new Size(Lwidth, Lheight);
                label.Location = new Point(LposX, LposY);
                label.Font = new Font(label.Font.FontFamily, LSize, label.Font.Style);

                this.Controls.Add(label);

                LposX += Lwidth + spacing;
                if ((i + 1) % columns == 0)
                {
                    LposX = 20;
                    LposY += Theight + spacing;
                }

                //Cria a descrição
                array[i] = dt.Rows[i].Field<string>("desc_Projeto");
                TextBox textBox = new TextBox();

                textBox.Multiline = true;
                textBox.Text = array[i];
                textBox.Size = new Size(Twidth, Theight);
                textBox.Location = new Point(TposX, TposY);
                textBox.Font = new Font(textBox.Font.FontFamily, Tsize, textBox.Font.Style);

                this.Controls.Add(textBox);

                TposX += Twidth + 25;
                if ((i + 1) % columns == 0)
                {
                    TposX = 20;
                    TposY += Theight + spacing;
                }

            }


        }

        private void desc_Proj_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExcluirProj_Click(object sender, EventArgs e)
        {
            ExcluirP exP = new ExcluirP();
            exP.ShowDialog();
            Recarregar();
        }

        public void Recarregar()
        {
            for (int i = this.Controls.Count - 1; i >= 3; i--)
            {
                Control controle = this.Controls[i];

                // Verificar se é a label ou um dos botões que você deseja remover
                if (controle is Label || controle is TextBox)
                {
                    this.Controls.RemoveAt(i); // Remover o controle
                }
            }
            MostrarProjetos();
        }
    }
}
