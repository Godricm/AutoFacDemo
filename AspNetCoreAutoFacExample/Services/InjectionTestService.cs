using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreAutoFacExample.Services
{
    public class InjectionTestService:IInjectionTestService
    {
        public string Test()
        {
            return "Success";
        }
    }
}
