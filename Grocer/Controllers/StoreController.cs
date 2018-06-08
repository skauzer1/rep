using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Grocer.Controllers {
    [Route("api/v1/[Controller]")]
    public class StoreController : Controller {
        [HttpGet("gds")]
        public async Task<IActionResult> GetGds() {
            throw new NotImplementedException();
        }


    }
}