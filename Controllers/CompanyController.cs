using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DVR.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace DVR.Controllers
{
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {

        private readonly IDouVacancyResearcheService _douVacancyResearcheService;
        private readonly IHostingEnvironment _host;


        public CompanyController(IHostingEnvironment host, IDouVacancyResearcheService douVacancyResearcheService)
        {
            _douVacancyResearcheService = douVacancyResearcheService;
            _host = host;
        }


        public async Task<IActionResult> Get()
        {
            _douVacancyResearcheService.RootPath = _host.WebRootPath;
            var urls = await _douVacancyResearcheService.GetUrlsAsync();
            return Ok(urls);
        }

    }
}