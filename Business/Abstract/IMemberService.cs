using Core.Utilities.Results;
using Entities.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMemberService
    {
        IDataResult<List<Member>> GetAll();
        IDataResult<Member> Get(int id);
        IResult Add(Member member);
        IResult Update(Member member);
        IResult Delete(int id);
      
    }



}
