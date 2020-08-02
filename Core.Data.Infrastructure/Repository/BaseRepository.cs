using Core.Data.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace Core.Data.Infrastructure.Repository
//{
//    public class DataRepository<T> : IRepository<T> where T : BaseAuditClass
//    {
//        private readonly DbContext context;
//        private DbSet<T> entities;
//        string errorMessage = string.Empty;

//        public DataRepository(DbContext context)
//        {
//            this.context = context;
//            entities = context.Set<T>();
//        }
//        public IEnumerable<T> GetAll()
//        {
//            return entities.AsEnumerable();
//        }

//        public T Get(int id)
//        {
//            return entities.FirstOrDefault(s => s.Id == id);
//        }
//        public void Insert(T entity)
//        {
//            if (entity == null)
//            {
//                throw new ArgumentNullException("entity");
//            }
//            entities.Add(entity);
//            context.SaveChanges();
//        }

//        public void Update(T entity)
//        {
//            if (entity == null)
//            {
//                throw new ArgumentNullException("entity");
//            }
//            context.SaveChanges();
//        }

//        public void Delete(T entity)
//        {
//            if (entity == null)
//            {
//                throw new ArgumentNullException("entity");
//            }
//            entities.Remove(entity);
//            context.SaveChanges();
//        }
//        public void Remove(T entity)
//        {
//            if (entity == null)
//            {
//                throw new ArgumentNullException("entity");
//            }
//            entities.Remove(entity);
//        }

//        public void SaveChanges()
//        {
//            context.SaveChanges();
//        }
//    }
//}
