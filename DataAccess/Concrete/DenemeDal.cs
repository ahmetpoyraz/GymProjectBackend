using Core.Utilities.Results;
using Dapper;
using DataAccess.Abstract;
using Entities.Conrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class DenemeDal : IDenemeDal
    {
        public List<Deneme> GetAll()
        {
            var sql = $"SELECT * FROM Deneme";

            using (var connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=GymProjectDb;Trusted_Connection=true"))
            {
                return connection.Query<Deneme>(sql).ToList();
            }
        }
    }
}
