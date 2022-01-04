using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troubleshooter.CLS
{
    class Login
    {
        public bool vld=true;
        public bool tm=false;
        public String msg="";
        SqlCommand cmd = new SqlCommand();
        Banco cn = new Banco();
        SqlDataReader dr;

        public bool vrfLogin(String usuario, String senha)
        {
            cmd.CommandText = "select * from usuarios where usuario = @usuario and senha = @senha";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);
            
            

            try
            {
                cmd.Connection = cn.Conectar();
                dr = cmd.ExecuteReader();
                
                if (dr.HasRows) 
                {
                    tm = true; 
                }
            }
            catch(SqlException)
            {
                this.msg = "Erro com banco de dados!";
            }
            return tm;
        }
    }
}
