using System;
using NMA_DESK.models;
using NMA_DESK.Vistas;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMA_DESK.Controladores
{
    public class UsuarioAdmin
    {
        public List<usuario> Consultar()
        {
            using(NMAEntities contexto = new NMAEntities()) 
            {
                return contexto.usuario.AsNoTracking().ToList();
            }
        }
        public void Guardar(usuario models)
        {
            using (NMAEntities contexto = new NMAEntities())
            {
                contexto.usuario.Add(models);
                contexto.SaveChanges();
            }
        }
    }
}
