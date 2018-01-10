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
    public class StatisticController : Controller
    {        
        private readonly ITagResultsService _tagResultsService;

        public StatisticController(ITagResultsService tagResultsService)
        {
            _tagResultsService = tagResultsService;
        }

        public IActionResult Get()
        {
            //var groups = TagGroups.GetAllTaggGroups();
            var results = _tagResultsService.GetResults();
            return Ok(results);
        }
    }
}