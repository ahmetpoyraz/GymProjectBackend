using Entities;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(string connection);
        T Get(int id, string connection);
        void Add(T entity,string connection);
        void Update(T entity, string connection);
        void Delete(int id,string tableName, string connection);
    }
}
