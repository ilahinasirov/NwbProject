using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entity.Results
{
    public class Result:IResult
    {
        public Result(string message, bool success)
        {
            success = Success;
            message = Message;
        }

        public Result(bool success)
        {
            success=Success;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}
