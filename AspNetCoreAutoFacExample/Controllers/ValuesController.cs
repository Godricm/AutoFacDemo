using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreAutoFacExample.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreAutoFacExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IValuesService _valuesService;
        private readonly IInjectionTestService _injection;
        public ValuesController(IValuesService valuesService, IInjectionTestService injection)
        {
            this._valuesService = valuesService;
            _injection = injection;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return this._valuesService.FindAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return this._valuesService.Find(id);
        }
         
        [HttpPost]
        public string Test()
        {
            return this._injection.Test();
        }
    }
}
