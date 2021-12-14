using Business.Abstract;
using Dapper.Contrib.Extensions;
using Entities.Conrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Try : ControllerBase
    {
        private readonly IDenemeService _denemeService;
        private readonly IMemberService _memberService;

        public Try(IDenemeService denemeService, IMemberService memberService)
        {
            _denemeService = denemeService;
            _memberService = memberService;
        }

        [HttpGet("denemee")]
        public IActionResult Deneme()
        {
            var result = _denemeService.GetAll();

            return Ok(result);
        }



        [HttpGet("member")]
        public IActionResult Member()
        {
            var result = _memberService.GetAll();
            return Ok(result);
        }


        [HttpGet("delete-member")]
        public IActionResult Delete()
        {
            var result = _memberService.Delete(2);
            return Ok(result);
        }


        [HttpPost("add-member")]
        public IActionResult Add(Member member)
        {
            _memberService.Add(member);

            return Ok();
        }



        [HttpPost("update-member")]
        public IActionResult Update(Member member)
        {
           
            var result = _memberService.Update(member);

            return Ok(result);
        }
    }
}
