using System;
using System.Data.SqlClient;
using Troubleshooter.Model;

namespace Troubleshooter.CLS
{
    class Login
    {
        GlobalVar gv = new();
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
                    dr.Read();
                    gv.userLgd = dr.GetInt32(0);
                    if (dr.GetInt32(5) == 1) { gv.vld = true; }
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