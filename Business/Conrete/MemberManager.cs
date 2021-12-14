using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Exception;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Conrete;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Conrete
{
    public class MemberManager : IMemberService
    {

        private readonly IMemberDal _memberdal;
        private readonly IConfiguration _configuration;


        public MemberManager(IMemberDal memberDal, IConfiguration configuration)
        {
            _memberdal = memberDal;
            _configuration = configuration;
                
        }
        [ExceptionAspect]
        [ValidationAspect(typeof(MemberValidator))]
        public IResult Add(Member member)
        {
            _memberdal.Add(member, _configuration.GetConnectionString("SqlConnection"));

            return new SuccessResult("Üye Eklendi");
        }

        public IResult Delete(int id)
        {
            _memberdal.Delete(id, "Member", _configuration.GetConnectionString("SqlConnection"));

            return new SuccessResult();
        }

        public IDataResult<Member> Get(int id)
        {
            var result = _memberdal.Get(id, _configuration.GetConnectionString("SqlConnection"));

            return new DataResult<Member>(result,true);
        }

        public IDataResult<List<Member>> GetAll()
        {
          var result = _memberdal.GetAll(_configuration.GetConnectionString("SqlConnection"));

            return new DataResult<List<Member>>(result, true);
        }

        public IResult Update(Member member)
        {

            _memberdal.Update(member, _configuration.GetConnectionString("SqlConnection"));

            return new SuccessResult();
        }

    }
}
