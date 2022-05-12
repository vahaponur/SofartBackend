using SofartBackend.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.Business.ResponseModels
{
    public class SuccessDataResponse<T> : DataResponse<T> 
    {
        public SuccessDataResponse(T data, string message) : base(data, ResultStatus.SUCCESS, message)
        {
        }
        public SuccessDataResponse(T data) : base(data, ResultStatus.SUCCESS)
        {
        }
        public SuccessDataResponse(string message) : base(default, ResultStatus.SUCCESS, message) { }
        public SuccessDataResponse() : base(default, ResultStatus.SUCCESS) { }
    }
}
