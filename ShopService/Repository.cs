using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ShopService
{
    /// <summary>
    /// Database repository. Allows database operations on all mapped types.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class Repository<T> where T : class
    {
        /// <summary>
        /// Gets all object of specified type
        /// </summary>
        /// <returns></returns>
        public static List<T> GetAll()
        {
            using (ShopContext ctx = new ShopContext())
            {
                return ctx.Set<T>().ToList();
            }
        }

        /// <summary>
        /// Gets object of specified type based on it's id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static T GetById(int id)
        {
            using (ShopContext ctx = new ShopContext())
            {
                return ctx.Set<T>().Find(id);
            }
        }

        /// <summary>
        /// Removes object of specified type
        /// </summary>
        /// <param name="entity"></param>
        public static void Remove(T entity)
        {
            using (ShopContext ctx = new ShopContext())
            {
                ctx.Set<T>().Remove(entity);
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// Removes object of specified type base on it's id
        /// </summary>
        /// <param name="id"></param>
        public static void Remove(int id)
        {
            using (ShopContext ctx = new ShopContext())
            {
                T entity = ctx.Set<T>().Find(id);
                ctx.Set<T>().Remove(entity);
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// Adds object of specified type to database
        /// </summary>
        /// <param name="entity"></param>
        public static void Add(T entity)
        {
            using (ShopContext ctx = new ShopContext())
            {
                ctx.Set<T>().Add(entity);
                ctx.SaveChanges();
            }
        }
    }
}
