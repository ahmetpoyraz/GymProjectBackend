using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Conrete
{
    public class DenemeManager : IDenemeService
    {
       private readonly IDenemeDal _denemeDal;

        public DenemeManager(IDenemeDal denemeDal)
        {
            _denemeDal = denemeDal;
                
        }
        public IDataResult<List<Deneme>> GetAll()
        {
            var result = _denemeDal.GetAll();
  

            return new DataResult<List<Deneme>>(result,true);
        }
    }
}
