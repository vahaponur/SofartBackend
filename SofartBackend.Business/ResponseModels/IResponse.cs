using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.Business.ResponseModels
{
    public interface IResponse
    {
        ResultStatus Status { get; set; }
        string Message { get; set; }
    }
}
