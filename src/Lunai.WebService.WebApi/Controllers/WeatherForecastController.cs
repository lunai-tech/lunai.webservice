using Lunai.WebService.Domain.Entities.MongoDocuments.ExpertDocuments;
using Lunai.WebService.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunai.WebService.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IExpertRepository _expertRepository;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IExpertRepository expertRepository)
        {
            _logger = logger;
            _expertRepository = expertRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<ExpertDocument>> GetAsync()
        {
            var tes = await _expertRepository.GetAll();

            return tes;
        }
    }
}
