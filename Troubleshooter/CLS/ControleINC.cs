using System;
using System.Data;
using System.Data.SqlClient;
using Troubleshooter.Model;

namespace Troubleshooter.CLS
{
    class ControleINC
    {
        public string rsm_problema;
        public string problema;
        public string cat_problema;
        public string cod_erro;
        public string troubleshoot;
        public int    tbs_definitiva;
        public int    tbs_console;
        public string cod_console;

        SqlCommand cmd = new SqlCommand();
        Banco bd = new Banco();
        SqlDataReader dr;
        GlobalVar gv = new GlobalVar();        

        public bool gravarINC()
        {
            Banco banco = new Banco();

            SqlConnection cn = banco.Conectar();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into probl_conhecidos " +
                "values (@rsm_problema, @problema, @cat_problema, @cod_erro, @troubleshoot, " +
                "@tbs_definitiva, @tbs_console, @cod_console, @fk_usuario);";
            command.Parameters.Add("@rsm_problema", SqlDbType.VarChar);
            command.Parameters.Add("@problema", SqlDbType.VarChar);
            command.Parameters.Add("@cat_problema", SqlDbType.VarChar);
            command.Parameters.Add("@cod_erro", SqlDbType.VarChar);
            command.Parameters.Add("@troubleshoot", SqlDbType.Text);
            command.Parameters.Add("@tbs_definitiva", SqlDbType.Int);
            command.Parameters.Add("@tbs_console", SqlDbType.Int);
            command.Parameters.Add("@cod_console", SqlDbType.Text);
            command.Parameters.Add("@fk_usuario", SqlDbType.Int);
            command.Parameters[0].Value = rsm_problema;
            command.Parameters[1].Value = problema;
            command.Parameters[2].Value = cat_problema;
            command.Parameters[3].Value = cod_erro;
            command.Parameters[4].Value = troubleshoot;
            command.Parameters[5].Value = tbs_definitiva;
            command.Parameters[6].Value = tbs_console;
            command.Parameters[7].Value = cod_console;
            command.Parameters[8].Value = gv.userLgd;
           
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.Desconectar();
            }
        }

        public ControleINC consultaProblemas(string chave_bsc, string busca)
        {            

            try
            {
                SqlConnection cn = bd.Conectar();
                //cmd = new SqlCommand("select * from probl_conhecidos where " + chave_bsc + " like @busca", cn);
                cmd = new SqlCommand("select probl_conhecidos.rsm_problema,problema,cat_problema,cod_erro,troubleshoot,tbs_definitiva,tbs_console,cod_console, usuarios.nome" +
                    " from probl_conhecidos, usuarios where " + chave_bsc + " like @busca and usuarios.id = probl_conhecidos.fk_usuario", cn);
                cmd.Parameters.AddWithValue("@busca", "%" + busca + "%");

                cmd.ExecuteNonQuery();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(gv.dt);

               return this;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                bd.Desconectar();
            }
        }       
    }
}
