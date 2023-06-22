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

        private static SQLiteConnection conexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=F:\\_Projetos_C#\\GerenciadorDeTarefas\\banco//bd_lista");
            conexao.Open();
            return conexao;
        }

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
    }
}
