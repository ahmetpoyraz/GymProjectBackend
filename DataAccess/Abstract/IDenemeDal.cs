using Core.Utilities.Results;
using Entities.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDenemeDal
    {
        List<Deneme> GetAll();
    }
}
