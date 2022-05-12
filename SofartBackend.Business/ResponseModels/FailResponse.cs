using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.Business.ResponseModels
{
    public class FailResponse : Response
    {
        public FailResponse() : base(ResultStatus.FAIL)
        {
        }

        public FailResponse( string message) : base(ResultStatus.FAIL, message)
        {
        }
    }
}
