using System;
using System.Collections.Generic;
using System.Text;
using EntityTry.ORM.Models;

namespace EntityTry.Repository
{
    public class RepositoryBase<T> where T:class
    {

        private static northwindContext context;
        // Singleton pattern.
        public northwindContext Context
        {
            get
            {
                if (context == null)
                    context = new northwindContext();
                return context;
            }
            set { context = value; }
        }


        public IList<T> Listele()
        {
            return Context.Set<T>().ToList();
        }

        public void mAdd (T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
            Context = new northwindContext();
        }
        public void mDelete (T entity)
        {
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
            context = new northwindContext();
        }
        public void mUpdate()
        {
            Context.SaveChanges();
        }

    }
}
