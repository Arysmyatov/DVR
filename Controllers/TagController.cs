using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DVR.Constants;
using DVR.Persistence;
using DVR.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace DVR.Controllers
{
    [Route("api/[controller]")]
    public class TagController  : Controller
    {
        public IActionResult Get()
        {
            var tags =  TagDescriptions.GetAllTagDescriptions().Select(t => new { Value = t.Name, Text = t.Name });
            return Ok(tags);
        }        
    }
}