using Dapper;
using Dapper.Contrib.Extensions;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Dapper
{
    public class DapperRepositoryBase<TEntity> : IEntityRepository<TEntity>
         where TEntity : class, IEntity, new()
       
    {

        public void Add(TEntity entity, string connection)
        {

            using (var conn = new SqlConnection(connection))
            {
                
                conn.Insert<TEntity>(entity);
            }
        }

        public void Delete(int id,string tableName, string connection)
        {
            var sql = $"DELETE {tableName} WHERE Id={id}";

            using (var conn = new SqlConnection(connection))
            {
                conn.Execute(sql);
                
            }
        }

        public TEntity Get(int id,string connection)
        {
            using (var conn = new SqlConnection(connection))
            {

               return conn.Get<TEntity>(id);
            }
        }

        public List<TEntity> GetAll(string connection)
        {
            using (var conn = new SqlConnection(connection))
            {
                return conn.GetAll<TEntity>().ToList();
            }

        }

        public void Update(TEntity entity, string connection)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Update<TEntity>(entity);
            }
        }
    }
}
