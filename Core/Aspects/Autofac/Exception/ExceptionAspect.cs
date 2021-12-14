

using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Exception
{
    public class ExceptionAspect:MethodInterception
    {
        //private readonly ILogger _logger;

        //public ExceptionAspect(ILogger logger)
        //{
        //    _logger = logger;
        //}
  
        protected override void OnException(IInvocation invocation, System.Exception e)
        {

            //_logger.Error("HATAAAA");
            Console.WriteLine(e.Message);
            
           
        }
    }
}
