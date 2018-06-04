using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArcsoftwareCoreApp.Controllers
{
    [Produces("application/json")]
    [Route("api/")]
    public class ApiController : Controller
    {
        [HttpPost("{id:int}")]
        public int ShowProduct(int id)
        {
            return id;
        }
    }
}