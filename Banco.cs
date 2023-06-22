using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace GerenciadorDeTarefas
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        //Conectar ao Banco de Dados
        public static SQLiteConnection conexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=F:\\_Projetos_C#\\GerenciadorDeTarefas\\banco//bd_lista.db");
            conexao.Open();

            return conexao;
        }

       /*public static DataTable obterTodosProjetos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = conexaoBanco().CreateCommand()) {
                    cmd.CommandText = "SELECT * FROM tb_Projetos";
                    da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                    da.Fill(dt);
                    return dt;
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }*/

        //Criar novo Projeto no BD
        public static void CriarProjeto(NovoProjeto np)
        {
            if(existeProjeto(np))
            {
                MessageBox.Show("Projeto Já Existe");
                return;
            }
            try
            {
                var cmd = conexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_Projetos (nome_Projeto, desc_Projeto) VALUES (@nome,@desc)";
                cmd.Parameters.AddWithValue("@nome", np.nomeProjeto);            
                cmd.Parameters.AddWithValue("@desc", np.descProjeto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Projeto Inserido");
                conexaoBanco().Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao Gravar novo Projeto");
                conexaoBanco().Close();
            }
        }


        //Verificar se já Existe Projeto com mesmo Nome
        public static bool existeProjeto(NovoProjeto np)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT nome_Projeto FROM tb_Projetos WHERE nome_Projeto =' "+np.nomeProjeto+"' ";
            da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
