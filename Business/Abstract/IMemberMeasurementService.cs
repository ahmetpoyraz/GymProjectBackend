using Core.Utilities.Results;
using Entities.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMemberMeasurementService
    {
        IDataResult<List<MemberMeasureMent>> GetAll();
        IDataResult<MemberMeasureMent> Get(int id);
        IResult Add(MemberMeasureMent member);
        IResult Update(MemberMeasureMent member);
        IResult Delete(int id);
    }
}

