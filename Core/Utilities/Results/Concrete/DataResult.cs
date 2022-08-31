using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    public class DataResult<T>:Result,IDataResult<T>
    {
        public DataResult(string message, bool isSuccess, T data) : base(message, isSuccess)
        {
            Data = data;
        }

        public DataResult(bool isSuccess,T data) : base(isSuccess)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
