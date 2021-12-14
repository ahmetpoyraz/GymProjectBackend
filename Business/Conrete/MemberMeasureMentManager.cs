using Business.Abstract;
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
    public class MemberMeasureMentManager : IMemberMeasurementService
    {
        private readonly IMemberMeasurementDal _memberMeasurementDal;
        private readonly IConfiguration _configuration;

        public MemberMeasureMentManager(IMemberMeasurementDal memberMeasurementDal, IConfiguration configuration)
        {
            _memberMeasurementDal = memberMeasurementDal;
            _configuration = configuration;
        }

        public IResult Add(MemberMeasureMent member)
        {
           _memberMeasurementDal.Add(member, _configuration.GetConnectionString("SqlConnection"));

            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            _memberMeasurementDal.Delete(id, "MemberMeasurement", _configuration.GetConnectionString("SqlConnection"));

            return new SuccessResult();
        }

        public IDataResult<MemberMeasureMent> Get(int id)
        {
            var result = _memberMeasurementDal.Get(id, _configuration.GetConnectionString("SqlConnection"));

            return new DataResult<MemberMeasureMent>(result, true);
        }

        public IDataResult<List<MemberMeasureMent>> GetAll()
        {

          var result = _memberMeasurementDal.GetAll( _configuration.GetConnectionString("SqlConnection"));

          return new DataResult<List<MemberMeasureMent>>(result, true);

        }

        public IResult Update(MemberMeasureMent memberMeasureMent)
        {
            _memberMeasurementDal.Update(memberMeasureMent, _configuration.GetConnectionString("SqlConnection"));

            return new SuccessResult();
        }
    }
}
