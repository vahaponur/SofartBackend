using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.Business.ResponseModels
{
    public class SuccessResponse : Response
    {
        public SuccessResponse(ResultStatus resultStatus, string message) : base(ResultStatus.SUCCESS, message)
        {
        }
        public SuccessResponse(ResultStatus resultStatus):base(ResultStatus.SUCCESS)
        {

        }
    }
}
