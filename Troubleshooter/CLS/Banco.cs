using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troubleshooter
{
    public class Banco
    {

        private string stringConexao = "Data Source=localhost;Initial Catalog=proj_base;Integrated Security=True";

        private SqlConnection cn;

        public void conexao()
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection Conectar()
        {            
            try
            {
                conexao();
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public SqlConnection Desconectar()
        {
            try
            {                
                conexao();
                cn.Close();
                return null;
            }
            catch (Exception)
            {
                return cn;
            }
        }

        public DataTable executarConsulta(string sql)
        {
            try
            {
                conexao();
                Conectar();
                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }

    }
}
