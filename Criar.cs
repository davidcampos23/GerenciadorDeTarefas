using System.Data;

namespace GerenciadorDeTarefas
{
    public partial class Criar : Form
    {
        DataTable dt = new DataTable();

        public Criar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovoProjeto projeto = new NovoProjeto();
            projeto.nomeProjeto = tb_nome.Text;
            projeto.descProjeto = tb_desc.Text;

            Banco.CriarProjeto(projeto);
        }
    }
}