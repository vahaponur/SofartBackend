using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.Business.ResponseModels
{
    public abstract class Response : IResponse
    {
        public ResultStatus Status { get ; set ; }
        public string Message { get; set; }
        public Response(ResultStatus resultStatus,string message)
        {
            Status = resultStatus;
            Message = message;
        }
        public Response(ResultStatus resultStatus)
        {
            Status = resultStatus;
      
        }
    }
}
