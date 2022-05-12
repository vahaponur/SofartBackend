using SofartBackend.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.Business.ResponseModels
{
    public interface IDataResponse<T>:IResponse
    {
        T Data { get; set; }
    }
}
