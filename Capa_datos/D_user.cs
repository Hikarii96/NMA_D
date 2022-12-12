using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Capa_entidad;


namespace Capa_datos
{
    public class D_users
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NMAEntities"].ConnectionString);

        public DataTable D_user(E_users obje)
        {
            SqlCommand cmd = new SqlCommand("logins", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", obje.email);
            cmd.Parameters.AddWithValue("@contrasena", obje.contrasena);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
