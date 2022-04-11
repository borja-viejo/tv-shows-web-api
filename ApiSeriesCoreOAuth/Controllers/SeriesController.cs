using ApiSeriesCoreOAuth.Models;
using ApiSeriesCoreOAuth.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiSeriesCoreOAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private readonly ISeriesRepository _seriesRepo;

        public SeriesController(ISeriesRepository seriesRepo)
        {
            _seriesRepo = seriesRepo;
        }

        [HttpGet]
        public ActionResult<List<Serie>> GetSeries()
        {
            return _seriesRepo.GetSeries();
        }

        [HttpGet("{id}")]
        public ActionResult<Serie> GetSerie(int id)
        {
            return _seriesRepo.GetSerie(id);
        }
    }
}
