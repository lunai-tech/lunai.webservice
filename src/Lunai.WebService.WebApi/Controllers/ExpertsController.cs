using Lunai.WebService.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lunai.WebService.WebApi.Controllers
{
    [Route("api/v1/experts")]
    [ApiController]
    public class ExpertsController : ControllerBase
    {
        private readonly IExpertService _expertService;

        public ExpertsController(IExpertService expertService)
        {
            _expertService = expertService;
        }


        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            return Ok( await _expertService.ListExperts());
        }

        
    }
}
