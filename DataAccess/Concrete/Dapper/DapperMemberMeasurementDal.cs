using Core.DataAccess.Dapper;
using DataAccess.Abstract;
using Entities.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Dapper
{
    public class DapperMemberMeasurementDal:DapperRepositoryBase<MemberMeasureMent>,IMemberMeasurementDal
    {
    }
}
