using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Core.DomainModels.Result
{
    public class Result<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public bool IsComplete { get; set; }

        public static Result<T> StatusComplete(T data)
        {
            return new Result<T>()
            {
                Data = data,
                IsComplete = true
            };
        }

        public static Result<T> StatusFailed(string messageFail)
        {
            return new Result<T>()
            {
                IsComplete = false,
                Message = messageFail
            };
        }
    }
}
