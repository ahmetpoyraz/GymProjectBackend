using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class LoginResult<T> : ILoginResult<T>
    {
        public LoginResult(T data,bool confirmSuccess, bool success, string message) 
        {
            ConfirmSuccess = confirmSuccess;
            Data = data;
            Success = success;
            Message = message;

        }
   
        public bool ConfirmSuccess { get; }

        public T Data { get; }

        public bool Success { get; }

        public string Message { get; }
    }
}
