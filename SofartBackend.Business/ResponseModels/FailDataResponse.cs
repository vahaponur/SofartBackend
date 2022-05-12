using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.Business.ResponseModels
{
    public class FailDataResponse<T>:DataResponse<T>
    {
        public FailDataResponse(T data, string message) : base(data, ResultStatus.FAIL, message)
        {
        }
        public FailDataResponse(T data) : base(data, ResultStatus.FAIL)
        {
        }
        public FailDataResponse(string message) : base(default, ResultStatus.FAIL, message) { }
        public FailDataResponse() : base(default, ResultStatus.FAIL) { }
    }
}
