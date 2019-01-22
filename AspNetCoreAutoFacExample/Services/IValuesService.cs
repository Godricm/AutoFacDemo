using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreAutoFacExample.Services
{
    public interface IValuesService
    {
        IEnumerable<string> FindAll();

        string Find(string id);
    }
}
