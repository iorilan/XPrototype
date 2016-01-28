using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XMock.Models
{
    public class AResult<T>
    {
        public AResult(T data)
        {
            Data = data;
            Success = true;
        }

        public AResult(T data, string error)
        {
            Data = data;
            Success = false;
            ErrorMsg = error;
        }

        public T Data { get; set; }
        public bool Success { get; set; }
        public string ErrorMsg { get; set; }
    }

    public class AResult
    {
        public AResult()
        {
            Success = true;
        }

        public AResult(string error)
        {
            Success = false;
            ErrorMsg = error;
        }

        public bool Success { get; set; }
        public string ErrorMsg { get; set; }
    }
}