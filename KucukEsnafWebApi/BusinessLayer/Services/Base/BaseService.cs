using DataLayer.Orm.Base;
using DataLayer.Orm.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Base
{
    public class BaseService<T> : IDisposable where T : BaseEntity
    {
        protected ECommerceEntities db;
        private DbSet<T> _context;

        public BaseService()
        {
            db = new ECommerceEntities();
            _context = db.Set<T>();

        }
        public void SaveChanges()
        {
            db.SaveChanges();
        }
        public List<T> GetAll()
        {
            return _context.Where(x => x.IsDeleted == false).ToList();
        }
       
        public void Dispose()
        {
            db.Dispose();
            this.Dispose();
        }
    }
}
