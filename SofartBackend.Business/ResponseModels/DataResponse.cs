using SofartBackend.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.Business.ResponseModels
{
    public abstract class DataResponse<T> : Response, IDataResponse<T> 
    {
        public T Data { get; set; }

        public DataResponse(T data, ResultStatus status,string message):base(status,message)
        {
            Data = data;

        }
        public DataResponse(T data,ResultStatus status):base(status)
        {
            Data=data;
        }
    }
}
