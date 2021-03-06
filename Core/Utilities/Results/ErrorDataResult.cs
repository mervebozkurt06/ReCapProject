using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        public ErrorDataResult(T data) : base(data, false) //mesaj vermek istemediğinde
        {

        }

        public ErrorDataResult(string message) : base(default, false, message)//sadece mesaj
        {

        }

        public ErrorDataResult() : base(default, false)//default=data
        {

        }
    }
}
