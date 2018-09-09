using JerryBibles.DAL;
using JerryBibles.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace JerryBibles.BLL
{
    public class LibrosBLL
    {
        public static bool Guardar(Libros libros)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.libros.Add(libros) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }

            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Editar(Libros libos)
        {
            bool paso = false;
            Contexto Contexto = new Contexto();

            try
            {
                Contexto.Entry(libos).State = System.Data.Entity.EntityState.Modified;
                if (Contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                Contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto Contexto = new Contexto();

            try
            {
                Libros libros = Contexto.libros.Find(Id);

                Contexto.libros.Remove(libros);
                if (Contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                Contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static Libros Buscar(int Id)
        {

            Contexto contexto = new Contexto();
            Libros libros = new Libros();
            try
            {
                libros = contexto.libros.Find(Id);
                 contexto.Dispose();
            }
            catch (Exception)

            {
                throw;
            }
            return libros;
        }

        public static List<Libros> GetList(Expression<Func<Libros, bool >> expression)
        {
            List<Libros> libros = new List<Libros>();
            Contexto contexto = new Contexto();
            try
            {
                libros = contexto.libros.Where(expression).ToList();
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return libros;
        }
    }
}
