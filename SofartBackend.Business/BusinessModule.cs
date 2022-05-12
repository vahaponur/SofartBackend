using Microsoft.Extensions.DependencyInjection;
using SofartBackend.Business.Concrete;
using SofartBackend.Business.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofartBackend.Business
{
    public static class BusinessModule
    {
        public static void Load(IServiceCollection serviceCollection)
        {
            DataAccess.DataAccessModule.Load(serviceCollection);
            serviceCollection.AddScoped<IUserService, UserManager>();
        }
    }
}
