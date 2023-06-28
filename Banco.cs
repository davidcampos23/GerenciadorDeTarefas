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
        private static SQLiteConnection conexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=F:\\_Projetos_C#\\GerenciadorDeTarefas\\banco//bd_lista.db");
            conexao.Open();

            return conexao;
        }

        //Tabela de Projetos ===========================================================================

        public static DataTable obterTodosProjetos()
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
        }

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

            }
        }

        //Excluir Projeto
        public static void excluirProjeto(string proj)
        {
            NovoProjeto np = new NovoProjeto();
            np.nomeProjeto = proj;

            if(!existeProjeto(np))
            {
                MessageBox.Show("Não existe Projeto");
                return;
            }

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tb_Projetos WHERE nome_Projeto = @nomeP";
                    cmd.Parameters.AddWithValue("@nomeP", proj);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Projeto Excluido!");
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }


        //Verificar se já Existe Projeto com mesmo Nome
        public static bool existeProjeto(NovoProjeto np)
        {
            bool res;

            using (SQLiteCommand cmd = conexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT nome_Projeto FROM tb_Projetos WHERE nome_Projeto = @np";
                cmd.Parameters.AddWithValue("@np", np.nomeProjeto);
                using(SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    res = reader.HasRows;
                }
            }
            return res;
        }

        //Colsultar Projetos
        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Pegar a quantidade de rows da tabela
        public static int tb_Rows()
        {
            int quant = 0;
            SQLiteDataAdapter da = null;
            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM tb_Projetos";
                    da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                    quant = Convert.ToInt32(cmd.ExecuteScalar());
                    return quant;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //Tabela de tarefas ============================================================================

        //Criar tarefa no bd
        public static void criarTarefas(NovoProjeto np)
        {
            try
            {
                var cmd = conexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_Tarefas (nome_Tarefa, desc_Tarefa) VALUES (@nome,@desc)";
                cmd.Parameters.AddWithValue("@nome", np.nomeTarefa);
                cmd.Parameters.AddWithValue("@desc", np.descTarefa);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nova Tarefa Inserida");
                conexaoBanco().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Gravar nova Tarefa!");

            }
        }

        //Excluir Tarefa no bd
        public static void excluirTarefa(string proj) 
        {
            NovoProjeto np = new NovoProjeto();
            np.nomeTarefa = proj;

            if (!existeTarefa(np))
            {
                MessageBox.Show("Não existe Tarefa");
                return;
            }

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tb_Tarefas WHERE nome_Tarefa = @nomeP";
                    cmd.Parameters.AddWithValue("@nomeP", proj);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tarefa Excluida!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Verificar se já Existe Projeto com mesmo Nome
        public static bool existeTarefa(NovoProjeto np)
        {
            bool res;

            using (SQLiteCommand cmd = conexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT nome_Tarefa FROM tb_Tarefas WHERE nome_Tarefa = @np";
                cmd.Parameters.AddWithValue("@np", np.nomeTarefa);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    res = reader.HasRows;
                }
            }
            return res;
        }

       

        
        
    }
}
