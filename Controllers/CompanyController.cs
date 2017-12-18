    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Xml.Serialization;
    using DVR.Constants;
    using DVR.Persistence;
    using DVR.Services;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;

    namespace DVR.Controllers
    {
        [Route("api/[controller]")]
        public class CompanyController : Controller
        {

            private readonly ICompanyRepository _companyRepository;
            private readonly IDouVacancyResearcheService _douVacancyResearcheService;
            private readonly IHostingEnvironment _host;


            public CompanyController(IHostingEnvironment host,
                                    IDouVacancyResearcheService douVacancyResearcheService,
                                    ICompanyRepository companyRepository)
            {
                _companyRepository = companyRepository;
                _douVacancyResearcheService = douVacancyResearcheService;
                _host = host;
            }


            public IActionResult Get()
            {
                _douVacancyResearcheService.RootPath = _host.WebRootPath;
                var companies = _companyRepository.GetCompanies().Where(c => c.Vacancies.Any());

                return Ok(companies);
            }

            [HttpGet("[action]")]
            public IActionResult GetJson()
            {
                var companiesJsonPath = FileLocation.GetJsonPath(_host.WebRootPath);
                var stream = new FileStream(companiesJsonPath, FileMode.Open, FileAccess.Read);
                return Ok(stream);
            }



            [HttpGet("[action]")]
            public async Task<IActionResult> Update()
            {
                _douVacancyResearcheService.RootPath = _host.WebRootPath;
                await _douVacancyResearcheService.UpdateCompanyRepository();
                return Ok("Companies are updated");
            }
        }
    }