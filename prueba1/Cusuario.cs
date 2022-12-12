using NMA_DESK.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Entity;

namespace NMA_DESK.Controladores
{
     class Cusuario
    {
        NMAEntities_ db;

        public void  create(usuario oUsuario)
        {
            try
            {
                using (db = new NMAEntities_())
                {
                    db.usuario.Add(oUsuario);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public List<usuario> Read()
    
        {
            try
            {
                using(db= new NMAEntities_())
                {
                    return db.usuario.ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public void Update(usuario oUsuario)
        {
            try
            {
                using (db = new NMAEntities_())
                {
                    db.Entry(oUsuario).State = EntityState.Modified;
                    db.SaveChanges();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Delete(int uId)
        {
            try
            {
                using (db = new NMAEntities_())
                {
                    db.usuario.Remove(db.usuario.Single(u => u.id_usuario == uId));
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public List<usuario> buscarId(int uId)
        {
            try
            {
                using(db = new NMAEntities_())
                {
                    return db.usuario.Where(u=> u.id_usuario== uId).ToList();
                }
            } 
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
