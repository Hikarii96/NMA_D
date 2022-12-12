using Capa_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_entidad;
using System.Data;

namespace Capa_Tipousuario
{
    public class T_users
    {
        D_users objd = new D_users();

        public DataTable T_user(E_users obje)
        {
            return objd.D_user(obje);   
        }


    }
}
