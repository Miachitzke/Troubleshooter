using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Troubleshooter.CLS;

namespace Troubleshooter.Model
{
    public class Controle
    {
        public int id;
        public string user;
        public string nome;
        public string senha;
        public string dt_cadastro;
        public int adm_user;
        public bool tm;

        public String msg = ""; 
        public bool acesso(String usuario, String senha)
        {
                Login loginCF = new Login();            
                tm = loginCF.vrfLogin(usuario, senha);
                if (!loginCF.msg.Equals(null))
                {
                    this.msg = loginCF.msg;
                }
            
            return tm;
        }

        internal static void abreTBS(object obj)
        {
            Application.Run(new frmCadTroubles());
        }

        internal static void abreConsulta(object obj)
        {
            Application.Run(new frmConsulta());
        }

        internal static void abreCadUser(object obj)
        {
            Application.Run(new frmCadastro());
        }

        public bool gravarUsuario()
            {
            Banco banco = new Banco();

            SqlConnection cn = banco.Conectar();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into usuarios " +
                "values (@usuario, @nome, @senha, @dt_cadastro, @adm_user);";
            command.Parameters.Add("@usuario", SqlDbType.VarChar);
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@senha", SqlDbType.VarChar);
            command.Parameters.Add("@dt_cadastro", SqlDbType.VarChar);
            command.Parameters.Add("@adm_user", SqlDbType.Int);
            command.Parameters[0].Value = user;
            command.Parameters[1].Value = nome;
            command.Parameters[2].Value = senha;
            command.Parameters[3].Value = dt_cadastro;
            command.Parameters[4].Value = adm_user;     

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.Desconectar();
            }
        }

        public bool excluirUsuario()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.Conectar();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from usuarios where id = @id;";
            command.Parameters.Add("@id", SqlDbType.VarChar);            
            command.Parameters[0].Value = id;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.Desconectar();
            }
        }

        public Controle consultaUsuario(int id)
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.Conectar();
                SqlCommand command = new SqlCommand("select * from usuarios", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        this.id = reader.GetInt32(0);
                        user = reader.GetString(1);
                        nome = reader.GetString(2);
                        senha = reader.GetString(3);
                        dt_cadastro = reader.GetString(4);
                        adm_user = reader.GetInt32(5);                 
                        return this;
                    }
                }

                return null;
            }
            catch(Exception)
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
