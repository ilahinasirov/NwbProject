using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entity.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, string message, bool success) : base(message, success)
        {
            data = Data;
        }

        public DataResult(T data, bool success) : base(success)
        {
            data = Data;
        }

        public T Data { get; set; }
    }
}
